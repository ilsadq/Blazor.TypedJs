using Microsoft.JSInterop;

namespace Blazor.TypedJs;

public class TypedJsProvider : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _module;

    public TypedJsProvider(IJSRuntime js)
    {
        _module = new(
            js.InvokeAsync<IJSObjectReference>("import", "./_content/Blazor.TypedJs/index.js").AsTask()
        );
    }

    public async Task Init(string id, string[] strings, int typeSpeed)
    {
        var js = await _module.Value;
        await js.InvokeVoidAsync("init", id, strings, typeSpeed);
    }

    public async Task Remove(string id)
    {
        var js = await _module.Value;
        await js.InvokeVoidAsync("dispose", id);
    }

    public async ValueTask DisposeAsync()
    {
        if (!_module.IsValueCreated) return;
        _module.Value.Dispose();
    }
}
