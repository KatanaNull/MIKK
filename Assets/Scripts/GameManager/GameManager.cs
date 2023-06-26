using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    //предметы

    public static bool _programmer/* = false*/ { get; private set; }

    public static bool _chip/* = false*/ { get; private set; }

    public static bool _keyKart/* = false*/ { get; private set; }

    public static bool _DetalInDoor/* = false*/ { get; private set; }

    public static void triggerProgrammer(bool flag)
    {
        _programmer = flag;
    }

    public static void triggerChip(bool flag)
    {
        _chip = flag;
    }

    public static void triggerKeyKart(bool flag)
    {
        _keyKart = flag;
    }

    public static void triggerDetalInDoor(bool flag)
    {
        _DetalInDoor = flag;
    }

    //компьютеры

    public static bool _computerInRoomGG/* = false*/ { get; private set; }

    public static bool _JobComputerInRoomGG/* = false*/ { get; private set; }

    public static bool _OpenInDoorGGRoom/* = false*/ { get; private set; }

    public static bool _computerInMedicalRoom/* = false*/ { get; private set; }

    public static bool _JobComputerInMedicalRoom/* = false*/ { get; private set; }

    public static bool _computerInRoom2/* = false*/ { get; private set; }

    public static bool _JobComputerInRoom2/* = false*/ { get; private set; }

    public static bool _computerInCapitansRoom/* = false*/ { get; private set; }

    public static bool _JobComputerInCapitansRoom/* = false*/ { get; private set; }

    public static bool _computerInSecurityRoom/* = false*/ { get; private set; }

    public static bool _JobComputerInSecurityRoom/* = false*/ { get; private set; }

    public static bool _computerInVegicleEngine/* = false*/ { get; private set; }

    public static bool _JobComputerInVegicleEngine/* = false*/ { get; private set; }

    public static bool _computerInLabolatory/* = false*/ { get; private set; }

    public static bool _JobComputerInLabolatory/* = false*/ { get; private set; }

    public static bool _3DPrinter/* = false*/ { get; private set; }

    public static bool _JobIn3DPrinter/* = false*/ { get; private set; }

    public static bool _computerInRoom1/* = false*/ { get; private set; }

    public static bool _JobComputerInRoom1/* = false*/ { get; private set; }

    public static bool _Safe/* = false*/ { get; private set; }

    public static bool _JobInSafe/* = false*/ { get; private set; }

    public static bool _computerInCabinCompany/* = false*/ { get; private set; }

    public static bool _JobComputerCabinCompany/* = false*/ { get; private set; }

    public static bool _Algoritm/* = false*/ { get; private set; }

    public static bool _JobInAlgoritm/* = false*/ { get; private set; }

    public static bool _OpenInDoorCapitansRoom/* = false*/ { get; private set; }

    public static bool _OpenInDoorLaboratory/* = false*/ { get; private set; }

    public static bool _OpenInDoorVehicleEngine/* = false*/ { get; private set; }

    public static bool _OpenInDoorSecurityRoom/* = false*/ { get; private set; }

    // Стартовая позиция

    public static Vector3 PlayerPosition = new Vector3(-3.53f, 0.03078127f, 0.6f);

    public static float x;

    public static float y;

    public static float z;

    public static void StartPosition(Vector3 position, float x1, float y1, float z1)
    {
        PlayerPosition = position;
        x = x1;
        y = y1;
        z = z1;
    }

    public static void triggerComputerInRoomGG(bool flag)
    {
        _computerInRoomGG = flag;
    }

    public static void triggerJobComputerInRoomGG(bool flag)
    {
        _JobComputerInRoomGG = flag;
    }

    public static void triggerInDoorRoomGG(bool flag)
    {
        _OpenInDoorGGRoom = flag;
    }

    public static void triggerComputerInMedicalRoom(bool flag)
    {
        _computerInMedicalRoom = flag;
    }

    public static void triggerJobComputerInMedicalRoom(bool flag)
    {
        _JobComputerInMedicalRoom = flag;
    }

    public static void triggerComputerInRoom2(bool flag)
    {
        _computerInRoom2 = flag;
    }

    public static void triggerJobComputerInRoom2(bool flag)
    {
        _JobComputerInRoom2 = flag;
    }

    public static void triggerComputerInCapitansRoom(bool flag)
    {
        _computerInCapitansRoom = flag;
    }

    public static void triggerJobComputerInCapitansRoom(bool flag)
    {
        _JobComputerInCapitansRoom = flag;
    }

    public static void triggerComputerInSecurityRoom(bool flag)
    {
        _computerInSecurityRoom = flag;
    }

    public static void triggerJobComputerInSecurityRoom(bool flag)
    {
        _JobComputerInSecurityRoom = flag;
    }

    public static void triggerComputerInVegicleEngine(bool flag)
    {
        _computerInVegicleEngine = flag;
    }

    public static void triggerJobComputerInVegicleEngine(bool flag)
    {
        _JobComputerInVegicleEngine = flag;
    }

    public static void triggerComputerInLabolatory(bool flag)
    {
        _computerInLabolatory = flag;
    }

    public static void triggerJobComputerInLabolatory(bool flag)
    {
        _JobComputerInLabolatory = flag;
    }

    public static void triggerJobIn3DPrinter(bool flag)
    {
        _JobIn3DPrinter = flag;
    }

    public static void triggerIn3DPrinter(bool flag)
    {
        _3DPrinter = flag;
    }

    public static void triggerComputerInRoom1(bool flag)
    {
        _computerInRoom1 = flag;
    }

    public static void triggerJobComputerInRoom1(bool flag)
    {
        _JobComputerInRoom1 = flag;
    }

    public static void triggerJobInSafe(bool flag)
    {
        _JobInSafe = flag;
    }

    public static void triggerInSafe(bool flag)
    {
        _Safe = flag;
    }

    public static void triggerComputerInCabinCompany(bool flag)
    {
        _computerInCabinCompany = flag;
    }

    public static void triggerJobComputerInCabinCompany(bool flag)
    {
        _JobComputerCabinCompany = flag;
    }

    public static void triggerJobInAlgoritm(bool flag)
    {
        _JobInAlgoritm = flag;
    }

    public static void triggerInAlgoritm(bool flag)
    {
        _Algoritm = flag;
    }

    public static void triggerInDoorCapitansRoom(bool flag)
    {
        _OpenInDoorCapitansRoom = flag;
    }

    public static void triggerInDoorLaboratory(bool flag)
    {
        _OpenInDoorLaboratory = flag;
    }

    public static void triggerInDoorSecurityRoom(bool flag)
    {
        _OpenInDoorSecurityRoom = flag;
    }

    public static void triggerInDoorVehicleEngine(bool flag)
    {
        _OpenInDoorVehicleEngine = flag;
    }

    public static void ResetManager()
    {
        _programmer = false;
        _chip = false;
        _keyKart = false;
        _DetalInDoor = false;
        _computerInRoomGG = false;
        _JobComputerInRoomGG = false;
        _OpenInDoorGGRoom = false;
        _computerInMedicalRoom = false;
        _JobComputerInMedicalRoom = false;
        _computerInRoom2 = false;
        _JobComputerInRoom2 = false;
        _computerInCapitansRoom = false;
        _JobComputerInCapitansRoom = false;
        _computerInSecurityRoom = false;
        _JobComputerInSecurityRoom = false;
        _computerInVegicleEngine = false;
        _JobComputerInVegicleEngine = false;
        _computerInLabolatory = false;
        _JobComputerInLabolatory = false;
        _3DPrinter = false;
        _JobIn3DPrinter = false;
        _computerInRoom1 = false;
        _JobComputerInRoom1 = false;
        _Safe = false;
        _JobInSafe = false;
        _computerInCabinCompany = false;
        _JobComputerCabinCompany = false;
        _Algoritm = false;
        _JobInAlgoritm = false;
        _OpenInDoorCapitansRoom = false;
        _OpenInDoorLaboratory = false;
        _OpenInDoorVehicleEngine = false;
        _OpenInDoorSecurityRoom = false;
    }
}
