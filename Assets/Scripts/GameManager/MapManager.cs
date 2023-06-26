using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class MapManager
{
    //комнаты
    public static Color GGRoom = new Color(1, 0.4f, 0.4f);
    public static Color MainCorridor = new Color(0, 0, 0);
    public static Color LivingRoom1 = new Color(0, 0, 0);
    public static Color LivingRoom2 = new Color(0, 0, 0);
    public static Color MedicalRoom = new Color(0, 0, 0);
    public static Color SecurityRoom = new Color(0, 0, 0);
    public static Color CabinCompany = new Color(0, 0, 0);
    public static Color CapitansRoom = new Color(0, 0, 0);
    public static Color Labolatory = new Color(0, 0, 0);
    public static Color VehicleEngine = new Color(0, 0, 0);

    //двери
    public static Color DoorGGRoom = new Color(0.44f, 0.44f, 0.44f);
    public static Color DoorLivingRoom2 = new Color(0, 0, 0);
    public static Color DoorLivingRoom1 = new Color(0, 0, 0);
    public static Color DoorMedicalRoom = new Color(0, 0, 0);
    public static Color DoorSecurityRoom = new Color(0, 0, 0);
    public static Color DoorCabinCompany = new Color(0, 0, 0);
    public static Color DoorCapitansRoom = new Color(0, 0, 0);
    public static Color DoorLabolatory = new Color(0, 0, 0);
    public static Color DoorVehicleEngine = new Color(0, 0, 0);
    public static Color LookDoor1 = new Color(0, 0, 0);
    public static Color LookDoor2 = new Color(0, 0, 0);
    public static Color LookDoor3 = new Color(0, 0, 0);

    public static void ResetManager()
    {
        GGRoom = new Color(1, 0.4f, 0.4f);
        MainCorridor = new Color(0, 0, 0);
        LivingRoom1 = new Color(0, 0, 0);
        LivingRoom2 = new Color(0, 0, 0);
        MedicalRoom = new Color(0, 0, 0);
        SecurityRoom = new Color(0, 0, 0);
        CabinCompany = new Color(0, 0, 0);
        CapitansRoom = new Color(0, 0, 0);
        Labolatory = new Color(0, 0, 0);
        VehicleEngine = new Color(0, 0, 0);

        DoorGGRoom = new Color(0.44f, 0.44f, 0.44f);
        DoorLivingRoom2 = new Color(0, 0, 0);
        DoorLivingRoom1 = new Color(0, 0, 0);
        DoorMedicalRoom = new Color(0, 0, 0);
        DoorSecurityRoom = new Color(0, 0, 0);
        DoorCabinCompany = new Color(0, 0, 0);
        DoorCapitansRoom = new Color(0, 0, 0);
        DoorLabolatory = new Color(0, 0, 0);
        DoorVehicleEngine = new Color(0, 0, 0);
        LookDoor1 = new Color(0, 0, 0);
        LookDoor2 = new Color(0, 0, 0);
        LookDoor3 = new Color(0, 0, 0);
    }
}
