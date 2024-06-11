using ExitGames.Client.Photon;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;

namespace GorillaXS.Basics
{
    internal class PUNNotifications : MonoBehaviourPunCallbacks
    {
        public override void OnJoinedRoom()
        {
            Notifier.Notify("Room Joined", string.Format("You have joined room {0} with {1}/{2} players", PhotonNetwork.CurrentRoom.Name, PhotonNetwork.CurrentRoom.PlayerCount, PhotonNetwork.CurrentRoom.MaxPlayers));
        }

        public override void OnLeftRoom()
        {
            Notifier.Notify("Room Left", "You have left the room");
        }

        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            Notifier.Notify("Player Joined", string.Format("{0} has joined the room", PlayFabAuthenticator.instance.GetSafety() ? newPlayer.DefaultName : newPlayer.NickName));
        }

        public override void OnPlayerLeftRoom(Player otherPlayer)
        {
            Notifier.Notify("Player Left", string.Format("{0} has left the room", PlayFabAuthenticator.instance.GetSafety() ? otherPlayer.DefaultName : otherPlayer.NickName));
        }

        public override void OnMasterClientSwitched(Player newMasterClient)
        {
            Notifier.Notify("Room Update", string.Format("The master client has been switched to {0}", PlayFabAuthenticator.instance.GetSafety() ? newMasterClient.DefaultName : newMasterClient.NickName), Base64Icon: "warning");
        }

        public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
        {
            Notifier.Notify("Room Update", "The room properties have been updated", Base64Icon: "warning");
        }
    }
}
