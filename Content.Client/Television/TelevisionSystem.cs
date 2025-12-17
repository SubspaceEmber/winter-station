namespace Content.Client.Television;

/// <summary>
/// This handles...
/// </summary>
public sealed class TelevisionSystem : EntitySystem
{
    /// <inheritdoc/>
    public override void Initialize()
    {
        //fetch channels
        //
    }

    private void UpdateVisuals()
    {
        
    }

    //updatechannellist
    //ask sever to send list of channels to this reciever
    
    //onchannelswitch
    //get whatever current program is on that channel from server, uses yml to actually display that
    
    //needs to send to server a request for a new program. server sends what that is

}
