using GorillaXS;
using Photon.Pun;
using Photon.Realtime;

namespace XSBasics
{
    internal class PUNNotifications : MonoBehaviourPunCallbacks
    {
        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            base.OnPlayerEnteredRoom(newPlayer);
            Notifier.Notify("Player Joined", $"{newPlayer.NickName} joined your room");
        }

        public override void OnPlayerLeftRoom(Player otherPlayer)
        {
            base.OnPlayerLeftRoom(otherPlayer);
            Notifier.Notify("Player Left", $"{otherPlayer.NickName} left your room");
        }
    }
}
