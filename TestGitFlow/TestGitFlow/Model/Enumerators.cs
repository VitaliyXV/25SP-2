using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public enum CategoryType
    {
        NONE,
        TOYS,
        PHONES,
        GAMES,
        FOODS
    }

    public enum PhoneType
    {
        SMARTPHONES,
        PUSHBUTTON
    }

    public enum OSType
    {
        ANDROID_7_0,
        ANDROID_6_0,
        ANDROID_5_1,
        ANDROID_5_0,
        ANDROID_4_4,
        ANDROID_4_3,
        ANDROID_4_2,
        ANDROID_4_1,
        ANDROID_4_0,
        ANDROID_2_3,
        ANDROID_2_1,
        ANDROID_2_0,
        iOS_10,
        iOS_9,
        iOS_8,
        iOS_7,
        iOS_6,
        Windows_10,
        Windows_8_1
    }

    public enum BluetoothSpecification
    {
        Bluetooth_5_0,
        Bluetooth_4_2,
        Bluetooth_4_1,
        Bluetooth_4_0,
        Bluetooth_3_0
    }
    
    public enum GamesGenre
    {
        Action,
        Adventure,
        Casual,
        Indie,
        RPG,
        RTS,
        MMO,
        Racing
    }

    public enum LicenseType
    {
        FreeToPlay,
        EarlyAccess,
        Demo,
        Freeware,
        Shareware        
    }

    public enum DistributeType
    {
        OpticalDrive,
        Downloadable,
        Steam
    }

    public enum SupportedPlatforms
    {
        PC,
        PS,
        XBOX,
        Android
    }

}
