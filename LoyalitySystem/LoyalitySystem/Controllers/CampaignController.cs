using AutoMapper;
using LoyalitySystem.DataTransferObjects;
using LoyalitySystem.Model;
using LoyalitySystem.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoyalitySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampaignRepository campaignRepository;
        private readonly ILoyalityUserRepository loyalityUserRepository;
        private readonly IPurchaseRepository purchaseRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public CampaignController(ICampaignRepository campaignRepository, 
            IMapper mapper, 
            ILoyalityUserRepository loyalityUserRepository,
            IPurchaseRepository purchaseRepository,
            IUserRepository userRepository)
        {
            this.campaignRepository = campaignRepository;
            this.mapper = mapper;
            this.loyalityUserRepository = loyalityUserRepository;
            this.purchaseRepository = purchaseRepository;
            this.userRepository = userRepository;
        }

        /// <summary>
        /// This API is used for testing. Not require for this purpose.
        /// </summary>
        /// <returns>Returns list of all campaigns</returns>
        [HttpGet]
        public ActionResult<List<Campaign>> GetCampaigns()
        {
            var campaigns = campaignRepository.GetCampaigns();
            return Ok(campaigns);
        }

        /// <summary>
        /// API for creation campaign.
        /// </summary>
        /// <param name="campaignInput"></param>
        /// <returns>Created campaign.</returns>
        [HttpPost("createCampaign")]
        public ActionResult<Campaign> CreateCampaign([FromBody] CampaignDTO campaignInput)
        {
            try
            {
                Campaign campaign = mapper.Map<Campaign>(campaignInput);

                Campaign retVal = campaignRepository.AddCampaign(campaign);
                campaignRepository.SaveChanges();

                return Created("Successfully created", retVal);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        /// <summary>
        /// Add customer in LoyalityUser list.
        /// </summary>
        /// <param name="loyalityUser"></param>
        /// <returns>Created Loylaity User.</returns>
        [HttpPost("addCustomer")]
        public ActionResult<LoyalityUser> AddCustomer([FromBody] LoyalityUser loyalityUser)
        {
            try
            {
                LoyalityUser retVal = loyalityUserRepository.AddLoyalityUser(loyalityUser);

                return Created("Successfully created loyality user", retVal);

            } catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Returns discount for user when he/she is buying something
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Discount number in percentage.</returns>
        [HttpGet("getDiscount/{userId}")]
        public ActionResult<int> GetDiscount(int userId)
        {
            try
            {
                LoyalityUser retVal = loyalityUserRepository.GetLoyalityUserByUserId(userId);

                return Ok(retVal.Discount);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Returns Loyality user list information.
        /// This API should be scheduled after expired duration of campaign.
        /// </summary>
        /// <returns>Loyality user list</returns>
        [HttpGet("getLoyalityUserList")]
        public ActionResult<List<LoyalityUserInformationDTO>> GetLoyalityUserList()
        {
            try { 
            // Should be returned list in csv file.
            List<LoyalityUserInformationDTO> loyalityUserInformationDTOs = new List<LoyalityUserInformationDTO>();
            List<Purchase> purchases = purchaseRepository.GetPurchases();

            Campaign campaign = campaignRepository.GetCampaignById(1); // for example 1
            // this type of retrive data will be scheduled in real system integration after 30 days of campaign
            // for later development => Create Stored Procedure for this type of query on SQL side because of memory

            // In this case companyId == campaignId
            // Because one company has one campaign

            List<LoyalityUser> loyalityUsers = loyalityUserRepository.GetLoyalityUsersByCompanyId(campaign.Id);
            List<User> users = new List<User>();
            foreach (var loyalityUser in loyalityUsers)
            {
                users.Add(userRepository.GetUserById(loyalityUser.UserId));
                
            }

            foreach(var user in users)
            {
                int numberOfPurchases = purchases.Count(u => u.UserId == user.Id);

                loyalityUserInformationDTOs.Add(new LoyalityUserInformationDTO
                {
                    CompanyName = campaign.CompanyName,
                    Name = user.Name,
                    SSN = user.SSN,
                    numberOfPurchases = numberOfPurchases
                });
            }

            return Ok(loyalityUserInformationDTOs);

            } catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Kad obavi kupovinu, onda ce se poslati ovaj zahtev kako bi se unelo u tabelu
        /// When finished purchase, it will appear in Purchase table.
        /// </summary>
        /// <param name="userId">Id of user</param>
        /// <returns>Successfully purchase</returns>
        [HttpPost("addPurchase/{userId}")]
        public ActionResult<Purchase> AddPurchase(int userId)
        {
            try
            {
                Purchase purchase = new Purchase();
                purchase.UserId = userId;

                purchase = purchaseRepository.AddPurchase(purchase);

                return Created("Successfully added purchase for userId customer", purchase);

            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
