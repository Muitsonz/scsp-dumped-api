
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

// Namespace: PRISM.Module.PrivacyOption
public interface IAsyncDecorator
{
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);
}

// Namespace: PRISM.Module.PrivacyOption
public class LoggingDecorator : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);

    private struct <SendAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        public System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Module.PrivacyOption
public enum MethodType : System.Enum
{
    public int value__;
    public static PRISM.Module.PrivacyOption.MethodType Get;
    public static PRISM.Module.PrivacyOption.MethodType Post;
}

// Namespace: PRISM.Module.PrivacyOption
public class RequestContext
{
    private int decoratorIndex;
    private PRISM.Module.PrivacyOption.IAsyncDecorator[] decorators;
    private System.Collections.Generic.Dictionary<string, string> headers;
    private string <BaseUrl>k__BackingField;
    private string <Url>k__BackingField;
    private object <Value>k__BackingField;
    private PRISM.Module.PrivacyOption.MethodType <Method>k__BackingField;
    private System.DateTimeOffset <Timestamp>k__BackingField;
    public string BaseUrl { get; set; }
    public string Url { get; set; }
    public object Value { get; set; }
    public PRISM.Module.PrivacyOption.MethodType Method { get; set; }
    public System.DateTimeOffset Timestamp { get; set; }
    public System.Collections.Generic.IReadOnlyDictionary<string, string> RequestHeaders { get; set; }
    public void SetRequestHeader(string name, string value);
    private System.Collections.Generic.Dictionary<string, string> GetHeaders();
    private PRISM.Module.PrivacyOption.IAsyncDecorator GetNextDecorator();
}

// Namespace: PRISM.Module.PrivacyOption
public class ResponseContext
{
    private byte[] bytes;
    private long <StatusCode>k__BackingField;
    private System.Collections.Generic.Dictionary<string, string> <ResponseHeaders>k__BackingField;
    public long StatusCode { get; set; }
    public System.Collections.Generic.Dictionary<string, string> ResponseHeaders { get; set; }
    public T GetResponseAs<T>();
}

// Namespace: PRISM.Module.PrivacyOption
public class SetBearerTokenHeaderDecorator : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    private string <_token>k__BackingField;
    private string _token { get; set; }
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);

    private struct <SendAsync>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        public PRISM.Module.PrivacyOption.SetBearerTokenHeaderDecorator <>4__this;
        public System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Module.PrivacyOption
public class SetContentTypeHeaderDecorator : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    private string <ContentType>k__BackingField;
    private string ContentType { get; set; }
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);

    private struct <SendAsync>d__5 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        public PRISM.Module.PrivacyOption.SetContentTypeHeaderDecorator <>4__this;
        public System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Module.PrivacyOption
public class SetTimeoutTokenDecorator : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    private System.TimeSpan timeout;
    private Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> PRISM.Module.PrivacyOption.IAsyncDecorator.SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);

    private struct <PRISM-Module-PrivacyOption-IAsyncDecorator-SendAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.SetTimeoutTokenDecorator <>4__this;
        public System.Threading.CancellationToken ct;
        public System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        private Cysharp.Threading.Tasks.TimeoutController <timeoutController>5__2;
        private System.Threading.CancellationTokenSource <linkedTokenSource>5__3;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Module.PrivacyOption
public class UnityWebRequestClient : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    private string baseUrl;
    private System.IProgress<float> progress;
    private System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> next;
    private PRISM.Module.PrivacyOption.IAsyncDecorator[] decorators;
    private UnityEngine.Networking.UnityWebRequest currentWebRequest;
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendGetRequestAsync(string url, System.Threading.CancellationToken ct);
    public Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> SendPostRequestAsync<TRequest>(string url, TRequest value, System.Threading.CancellationToken ct);
    private Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> PRISM.Module.PrivacyOption.IAsyncDecorator.SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);
    public void Abort();
    private Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> _invokeRecursive(PRISM.Module.PrivacyOption.RequestContext context, System.Threading.CancellationToken ct);
    private UnityEngine.Networking.UnityWebRequest _createRequest(PRISM.Module.PrivacyOption.MethodType method, string url, object value);

    private struct <PRISM-Module-PrivacyOption-IAsyncDecorator-SendAsync>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.UnityWebRequestClient <>4__this;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        public System.Threading.CancellationToken ct;
        private UnityEngine.Networking.UnityWebRequest <webRequest>5__2;
        private Awaiter<UnityEngine.Networking.UnityWebRequest> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SendGetRequestAsync>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.UnityWebRequestClient <>4__this;
        public string url;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    private struct <SendPostRequestAsync>d__8`1<TRequest> : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.UnityWebRequestClient <>4__this;
        public string url;
        public TRequest value;
        public System.Threading.CancellationToken ct;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__1;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

// Namespace: PRISM.Module.PrivacyOption
public class WaitDecorator : PRISM.Module.PrivacyOption.IAsyncDecorator
{
    private System.TimeSpan timeout;
    private Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext> PRISM.Module.PrivacyOption.IAsyncDecorator.SendAsync(PRISM.Module.PrivacyOption.RequestContext requestContext, System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync, System.Threading.CancellationToken ct);

    private struct <PRISM-Module-PrivacyOption-IAsyncDecorator-SendAsync>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
    {
        public int <>1__state;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<PRISM.Module.PrivacyOption.ResponseContext> <>t__builder;
        public PRISM.Module.PrivacyOption.WaitDecorator <>4__this;
        public System.Threading.CancellationToken ct;
        public System.Func<PRISM.Module.PrivacyOption.RequestContext, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask<PRISM.Module.PrivacyOption.ResponseContext>> nextAsync;
        public PRISM.Module.PrivacyOption.RequestContext requestContext;
        private Awaiter <>u__1;
        private Awaiter<PRISM.Module.PrivacyOption.ResponseContext> <>u__2;
        private void MoveNext();
        private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

private class <PrivateImplementationDetails>
{
    private static __StaticArrayInitTypeSize=734 164174BB03D5AB09C9CF25408F4C8BD64A398593DADEC05EA2AB8A7BFEF4CD39;
    private static __StaticArrayInitTypeSize=464 5B0748E378B867E90F342C0D51A0AEA3C7D23CB4F2DE7464BCBAAA8E42A5F860;

    private struct __StaticArrayInitTypeSize=464 : System.ValueType
    {
    }

    private struct __StaticArrayInitTypeSize=734 : System.ValueType
    {
    }
}
