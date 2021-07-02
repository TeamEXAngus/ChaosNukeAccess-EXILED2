using Exiled.Events.EventArgs;
using Exiled.API.Extensions;
using Exiled.API.Enums;

namespace ChaosNukeAccess
{
    internal class InteractingDoor
    {
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (ev.Door.Type() == DoorType.NukeSurface &&
                ev.Player.CurrentItem.id == ItemType.KeycardChaosInsurgency)
            {
                ev.IsAllowed = true;
            }
        }
    }
}