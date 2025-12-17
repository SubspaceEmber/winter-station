using Content.Shared.Television;
using Robust.Client.UserInterface;

namespace Content.Client.Television.UI;

public sealed class TelevisionBoundInterface : BoundUserInterface
{
    private TelevisionWindow? _interface;
    
    public TelevisionBoundInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey) 
    {
        
    }
    
    protected override void Open()
    {
        base.Open();

        _interface = new TelevisionWindow();
        _interface.OpenCentered();
    }
    
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (!disposing)
            return;
        _interface?.Dispose();
    }
    
}
