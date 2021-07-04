using Exiled.API.Features;
using System;

namespace ChaosNukeAccess
{
    public class ChaosNukeAccess : Plugin<Config>
    {
        public static ChaosNukeAccess Instance;

        public override Version Version { get; } = new Version(1, 0, 1);
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        private InteractingDoor interactingDoor;

        public override void OnEnabled()
        {
            Instance = this;

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