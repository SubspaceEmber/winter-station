namespace Content.Server.Television.Systems;

/// <summary>
/// This handles...
/// </summary>
public sealed class TelevisionSystem : EntitySystem
{
    /// <inheritdoc/>
    public override void Initialize()
    {
        //generate channels and IDs from yml. for loop that makes a channel ID for each one
        //generate programming IDs from yml.make data structure with array of programming IDs for each channel ID
        //based on the channels listed
        //
        
    }
    
    //Needs to generate channels and update its current programming based on what events are happening
    
    //variable to store current programming, probably with a UID of some sort. program 001 is the cooking show etc etc
    
    //updateschedule
    //when client tv asks. send current programming to it with its uid, client needs to check what that is.
    //maybe make YML component to store set channel presets. yml has allowed channels, function here generates schedule
    //based on that, so like, channel 45 can only have programming 001, 020, 030 etc, once that's known can pick one at random
    //probably out of an array and send it to client recivers
    
    //sendprogramming (channel ID, uid?)
    //if channel ID matches generated then
    //send current programming
    
    //onalertlevelchanged
    //get whatever the alert was, then send the relevent programming number for the alert to all recievers
    
    
    
    
}
