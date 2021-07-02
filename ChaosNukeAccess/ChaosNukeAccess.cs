using Exiled.API.Features;
using System;

namespace ChaosNukeAccess
{
    public class ChaosNukeAccess : Plugin<Config>
    {
        private static ChaosNukeAccess singleton = new ChaosNukeAccess();
        public static ChaosNukeAccess Instance => singleton;

        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        private InteractingDoor interactingDoor;

        public override void OnEnabled()
        {
            interactingDoor = new InteractingDoor();

            Exiled.Events.Handlers.Player.InteractingDoor += interactingDoor.OnInteractingDoor;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.InteractingDoor -= interactingDoor.OnInteractingDoor;

            interactingDoor = null;
        }
    }
}