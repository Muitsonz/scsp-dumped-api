
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

// Namespace: PRISM.Module.Notification
public class DummyMessagingHandler : PRISM.Service.Notification.IMessagingHandler, System.IDisposable
{
    private bool <IsListening>k__BackingField;
    public bool IsListening { get; set; }
    public System.IObservable<Firebase.Messaging.FirebaseMessage> MessageReceived { get; set; }
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(bool firstInitialize, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask AskMessagingPermissionAsync(System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask SetListeningAsync(bool listening, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask SwitchTopicAsync(Topic type, bool enable, System.Threading.CancellationToken token);
}

// Namespace: PRISM.Module.Notification
public class FCMHandler : PRISM.Service.Notification.IMessagingHandler, System.IDisposable
{
    private static string TopicStartGasha;
    private static string TopicStartEvent;
    private static string TopicStartSeason;
    private static string TopicBow;
    private static string TopicStartStream;
    private static string TopicBowImportant;
    private static int MaxRetryCount;
    private string myToken;
    private UniRx.CompositeDisposable disposables;
    private System.IObservable<UniRx.Unit> firebaseInitialized;
    private System.IObservable<string> TokenReceived { get; set; }
    public System.IObservable<Firebase.Messaging.FirebaseMessage> MessageReceived { get; set; }
    public bool IsListening { get; set; }
    public Cysharp.Threading.Tasks.UniTask InitializeAsync(bool firstInitialize, System.Threading.CancellationToken token);
    private Cysharp.Threading.Tasks.UniTask _initializeForPlatformAsync(bool firstInitialize, System.Threading.CancellationToken token);
    public void Dispose();
    public Cysharp.Threading.Tasks.UniTask AskMessagingPermissionAsync(System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask SetListeningAsync(bool listening, System.Threading.CancellationToken token);
    public Cysharp.Threading.Tasks.UniTask SwitchTopicAsync(Topic type, bool enable, System.Threading.CancellationToken token);
    private void _tokenReceived(string token);
    private Cysharp.Threading.Tasks.UniTaskVoid _receiveTokenOnMainThread(string token);
    private Cysharp.Threading.Tasks.UniTask<T> _callAPIAsyc<T>(System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<T>> method, System.Func<string> errorTextGenerator, int retryMaxCount, System.Threading.CancellationToken token);
    private Cysharp.Threading.Tasks.UniTask _waitForOnline(System.Threading.CancellationToken token);

    private class <>c
    {
        public static <>c <>9;
        public static System.Func<bool> <>9__26_0;
        private bool <_waitForOnline>b__26_0();
    }

    private struct <InitializeAsync>d__17 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        public PRISM.Module.Notification.FCMHandler <>4__this;
        public System.Threading.CancellationToken token;
        public bool firstInitialize;
        private Awaiter<UniRx.Unit> <>u__1;
        private Awaiter <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SetListeningAsync>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SwitchTopicAsync>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_callAPIAsyc>d__25`1<T> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
        public PRISM.Module.Notification.FCMHandler <>4__this;
        public System.Threading.CancellationToken token;
        public System.Func<System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<T>> method;
        public int retryMaxCount;
        public System.Func<string> errorTextGenerator;
        private int <retryCount>5__2;
        private Awaiter <>u__1;
        private Awaiter<T> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_initializeForPlatformAsync>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <_receiveTokenOnMainThread>d__24 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
        public PRISM.Module.Notification.FCMHandler <>4__this;
        public string token;
        private Awaiter <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Module.Notification
public class MessagingConst
{
    public static string TopicStartGasha;
    public static string TopicStartEvent;
    public static string TopicStartSeason;
    public static string TopicBow;
}

// Namespace: PRISM.Module.Notification
public class NotificationHandlerSilent : PRISM.Service.Notification.INotificationHandler
{
    public void Initialize();
    public Cysharp.Threading.Tasks.UniTask<bool> AskNotificationPermissionAsync();
    public string SetScheduleNotification(PRISM.Service.Notification.NotificationModel model);
    public void RemoveScheduledNotification(string id);
    public void RemoveNotification(string id);
    public void RemoveBadge();
    public void OnApplicationSuspend();
    public string GetLastRespondedNotificationId();
    public void RemoveAllScheduledNotification();
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=282 313351C7B9E743AF1480778F544B1C7329057762A8B0C4603C306251A111E4E4;
    private static __StaticArrayInitTypeSize=194 78F028CA436677FC49A6D39B2C9153AC5CD6A0291312242386342AC6F3130906;

    private struct __StaticArrayInitTypeSize=194 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=282 : System.ValueType
    {
    }
}
