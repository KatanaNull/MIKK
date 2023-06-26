using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Map
{
    public class Map : MonoBehaviour
    {
        [SerializeField] private Image RoomGG;
        [SerializeField] private Image LivingRoom1;
        [SerializeField] private Image LivingRoom2;
        [SerializeField] private Image MedicalRoom;
        [SerializeField] private Image CapitansRoom;
        [SerializeField] private Image SecurityRoom;
        [SerializeField] private Image MainCorridor;
        [SerializeField] private Image CabinCompany;
        [SerializeField] private Image Laboratory;
        [SerializeField] private Image VehineEngine;

        [SerializeField] private Image DoorRoomGG;
        [SerializeField] private Image DoorLivingRoom1;
        [SerializeField] private Image DoorLivingRoom2;
        [SerializeField] private Image DoorMedicalRoom;
        [SerializeField] private Image DoorCapitansRoom;
        [SerializeField] private Image DoorSecurityRoom;
        [SerializeField] private Image DoorCabinCompany;
        [SerializeField] private Image DoorLaboratory;
        [SerializeField] private Image DoorVehineEngine;
        [SerializeField] private Image LookDoor1;
        [SerializeField] private Image LookDoor2;
        [SerializeField] private Image LookDoor3;

        void Start()
        {
            UpdateMap();
        }

        public void UpdateMap()
        {
            RoomGG.color = MapManager.GGRoom;
            LivingRoom1.color = MapManager.LivingRoom1;
            LivingRoom2.color = MapManager.LivingRoom2;
            MedicalRoom.color = MapManager.MedicalRoom;
            CapitansRoom.color = MapManager.CapitansRoom;
            SecurityRoom.color = MapManager.SecurityRoom;
            MainCorridor.color = MapManager.MainCorridor;
            CabinCompany.color = MapManager.CabinCompany;
            Laboratory.color = MapManager.Labolatory;
            VehineEngine.color = MapManager.VehicleEngine;

            DoorRoomGG.color = MapManager.DoorGGRoom;
            DoorLivingRoom1.color = MapManager.DoorLivingRoom1;
            DoorLivingRoom2.color = MapManager.DoorLivingRoom2;
            DoorMedicalRoom.color = MapManager.DoorMedicalRoom;
            DoorCapitansRoom.color = MapManager.DoorCapitansRoom;
            DoorSecurityRoom.color = MapManager.DoorSecurityRoom;
            DoorCabinCompany.color = MapManager.DoorCabinCompany;
            DoorLaboratory.color = MapManager.DoorLabolatory;
            DoorVehineEngine.color = MapManager.DoorVehicleEngine;
            LookDoor1.color = MapManager.LookDoor1;
            LookDoor2.color = MapManager.LookDoor2;
            LookDoor3.color = MapManager.LookDoor3;
        }
    }
}