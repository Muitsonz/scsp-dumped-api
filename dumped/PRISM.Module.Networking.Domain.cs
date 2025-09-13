
private class <Module>
{
}

private class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    private static MonoScriptData Get();

    private struct MonoScriptData : System.ValueType
    {
        public byte[] FilePathsData;
        public byte[] TypesData;
        public int TotalTypes;
        public int TotalFiles;
        public bool IsEditorOnly;
    }
}

// Namespace: PRISM.Module.Networking.Implementation
public class ResettableServiceContainer
{
    private PRISM.Module.Networking.Implementation.ServerServiceContainer container;
    public PRISM.Service.Communicator.IServiceContainer ServiceContainer { get; set; }
    public void Reset();
}

// Namespace: PRISM.Module.Networking.Implementation
private class ServerServiceContainer : PRISM.Service.Communicator.IServiceContainer, PRISM.Legacy.IServiceContainerForLegacy
{
    private PRISM.Domain.AnnounceService announceService;
    private PRISM.Module.Networking.Implementation.Service.Announce.AnnounceServiceForTitle announceServiceForTitle;
    private PRISM.Domain.AuthService authService;
    private PRISM.Domain.BannerService bannerService;
    private PRISM.Domain.BillingService billingService;
    private PRISM.Domain.ChallengeTourService challengeTourService;
    private PRISM.Domain.CostumeService costumeService;
    private PRISM.Domain.DirectMessageService directMessageService;
    private PRISM.Domain.DressUpRoomService dressUpRoomService;
    private PRISM.Domain.EventRankingService eventRankingService;
    private PRISM.Domain.ExchangeService exchangeService;
    private PRISM.Domain.FesUnitService fesUnitService;
    private PRISM.Domain.FriendService friendService;
    private PRISM.Domain.FriendInvitationService friendInvitationService;
    private PRISM.Domain.GalleryService galleryService;
    private PRISM.Domain.GameService gameService;
    private PRISM.Domain.GameSettingService gameSettingService;
    private PRISM.Domain.GashaService gashaService;
    private PRISM.Domain.HomeService homeService;
    private PRISM.Domain.IdolService idolService;
    private PRISM.Domain.InspectService inspectService;
    private PRISM.Domain.IntroductionService introductionService;
    private PRISM.Domain.LiveService liveService;
    private PRISM.Domain.LiveEventAlphaService liveEventAlphaService;
    private PRISM.Domain.LiveEventAllSongService liveEventAllSongService;
    private PRISM.Domain.LoginBonusService loginBonusService;
    private PRISM.Domain.MedalGashaService medalGashaService;
    private PRISM.Domain.MissionService missionService;
    private PRISM.Domain.MobileService mobileService;
    private PRISM.Domain.PieceService pieceService;
    private PRISM.Domain.PresentService presentService;
    private PRISM.Domain.ProduceService produceService;
    private PRISM.Domain.ProduceIdolService produceIdolService;
    private PRISM.Domain.ProductService productService;
    private PRISM.Domain.ProfileService profileService;
    private PRISM.Domain.SeasonMissionService seasonMissionService;
    private PRISM.Domain.ShinyCompetitionService shinyCompetitionService;
    private PRISM.Domain.ShopService shopService;
    private PRISM.Domain.SpecialMissionService specialMissionService;
    private PRISM.Domain.StaminaService staminaService;
    private PRISM.Domain.StoryService storyService;
    private PRISM.Domain.StreamProgramService streamProgramService;
    private PRISM.Domain.SupportCharacterService supportCharacterService;
    private PRISM.Domain.TransferService transferService;
    private PRISM.Domain.TutorialService tutorialService;
    private PRISM.Domain.UserService userService;
    private PRISM.Domain.AchievementService achievementService;
    private PRISM.Domain.LoginBonusPassService loginBonusPassService;
    private PRISM.Domain.GiftEventService giftEventService;
    private PRISM.Domain.RunwayService runwayService;
    private PRISM.Domain.TechnicalChallengeService technicalChallengeService;
    public PRISM.Domain.IAnnounceService GetAnnounceService(bool forTitle);
    public PRISM.Domain.IAuthService GetAuthService();
    public PRISM.Domain.IBannerService GetBannerService();
    public PRISM.Domain.IBillingService GetBillingService();
    public PRISM.Domain.IChallengeTourService GetChallengeTourService();
    public PRISM.Domain.ICostumeService GetCostumeService();
    public PRISM.Domain.IDirectMessageService GetDirectMessageService();
    public PRISM.Domain.IDressUpRoomService GetDressUpRoomService();
    public PRISM.Domain.IEventRankingService GetEventRankingService();
    public PRISM.Domain.IExchangeService GetExchangeService();
    public PRISM.Domain.IFesUnitService GetFesUnitService();
    public PRISM.Domain.IFriendService GetFriendService();
    public PRISM.Domain.IFriendInvitationService GetFriendInvitationService();
    public PRISM.Domain.IGalleryService GetGalleryService();
    public PRISM.Domain.IGameService GetGameService();
    public PRISM.Domain.IGameSettingService GetGameSettingService();
    public PRISM.Domain.IGashaService GetGashaService();
    public PRISM.Domain.IHomeService GetHomeService();
    public PRISM.Domain.IIdolService GetIdolService();
    public PRISM.Domain.IInspectService GetInspectService();
    public PRISM.Domain.IIntroductionService GetIntroductionService();
    public PRISM.Domain.ILiveService GetLiveService();
    public PRISM.Domain.ILiveEventAlphaService GetLiveEventAlphaService();
    public PRISM.Domain.ILiveEventAllSongService GetLiveEventAllSongService();
    public PRISM.Domain.ILoginBonusService GetLoginBonusService();
    public PRISM.Domain.IMedalGashaService GetMedalGashaService();
    public PRISM.Domain.IMissionService GetMissionService();
    public PRISM.Domain.IMobileService GetMobileService();
    public PRISM.Domain.IPieceService GetPieceService();
    public PRISM.Domain.IPresentService GetPresentService();
    public PRISM.Domain.IProduceService GetProduceService();
    public PRISM.Domain.IProduceIdolService GetProduceIdolService();
    public PRISM.Domain.IProductService GetProductService();
    public PRISM.Domain.IProfileService GetProfileService();
    public PRISM.Domain.ISeasonMissionService GetSeasonMissionService();
    public PRISM.Domain.IShinyCompetitionService GetShinyCompetitionService();
    public PRISM.Domain.IShopService GetShopService();
    public PRISM.Domain.ISpecialMissionService GetSpecialMissionService();
    public PRISM.Domain.IStaminaService GetStaminaService();
    public PRISM.Domain.IStoryService GetStoryService();
    public PRISM.Domain.IStreamProgramService GetStreamProgramService();
    public PRISM.Domain.ISupportCharacterService GetSupportCharacterService();
    public PRISM.Domain.ITransferService GetTransferService();
    public PRISM.Domain.ITutorialService GetTutorialService();
    public PRISM.Domain.IUserService GetUserService();
    public PRISM.Domain.IAchievementService GetAchievementService();
    public PRISM.Domain.ILoginBonusPassService GetLoginBonusPassService();
    public PRISM.Domain.IGiftEventService GetGiftEventService();
    public PRISM.Domain.IRunwayService GetRunwayService();
    public PRISM.Domain.ITechnicalChallengeService GetTechnicalChallengeService();
}

// Namespace: PRISM.Module.Networking.Implementation.Service.Announce
private class AnnounceServiceForTitle : PRISM.Domain.IAnnounceService
{
    private string targetPlatform;
    private PRISM.Domain.TitleAnnounceService titleService;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetAnnounceListReply> GetAnnounceListAsync(string cursor, int limit, AnnounceCategory category, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetAnnouncePopUpReply> GetAnnouncePopUpAsync(System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IConfirmedAnnounceReply> ConfirmedAnnounceAsync(string articleId, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.Networking.IGetAnnounceDetailReply> GetAnnounceDetailAsync(string articleId, System.Threading.CancellationToken ct);

    private struct <GetAnnounceDetailAsync>d__6 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IGetAnnounceDetailReply> <>t__builder;
        public PRISM.Module.Networking.Implementation.Service.Announce.AnnounceServiceForTitle <>4__this;
        public string articleId;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetTitleAnnounceDetailReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <GetAnnounceListAsync>d__3 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.Networking.IGetAnnounceListReply> <>t__builder;
        public PRISM.Module.Networking.Implementation.Service.Announce.AnnounceServiceForTitle <>4__this;
        public string cursor;
        public int limit;
        public AnnounceCategory category;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.Networking.IGetTitleAnnounceListReply> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=268 AF172923F4B74B9638611D28DEB3345DFA0035BBD86DE71D039597876E30FD3B;
    private static __StaticArrayInitTypeSize=220 CBE0F3BC0B7841E3AB402E992D32A618A3F0499B44D9CC7DCBF588C4237D86C8;

    private struct __StaticArrayInitTypeSize=220 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=268 : System.ValueType
    {
    }
}
