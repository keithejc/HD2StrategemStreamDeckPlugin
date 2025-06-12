using HD2StrategemStreamDeckPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD2StrategemStreamDeckPlugin
{
    internal enum StratagemId
    {
        LIFT850JumpPack = 0,
        B1SupplyPack = 1,
        AXLAS5GuardDogRover = 2,
        SH20BallisticShieldBackpack = 3,
        SH32ShieldGeneratorPack = 4,
        AXAR23GuardDog = 5,
        MG43MachineGun = 6,
        APW1AntiMaterielRifle = 7,
        M105Stalwart = 8,
        EAT17ExpendableAntitank = 9,
        GR8RecoillessRifle = 10,
        FLAM40Flamethrower = 11,
        AC8Autocannon = 12,
        MG206HeavyMachineGun = 13,
        RL77AirburstRocketLauncher = 14,
        MLS4XCommando = 15,
        RS422Railgun = 16,
        FAF14SPEARLauncher = 17,
        GL21GrenadeLauncher = 18,
        LAS98LaserCannon = 19,
        ARC3ArcThrower = 20,
        LAS99QuasarCannon = 21,
        EXO45PatriotExosuit = 22,
        EXO49EmancipatorExosuit = 23,
        EMG101HMGEmplacement = 24,
        FX12ShieldGeneratorRelay = 25,
        AARC3TeslaTower = 26,
        MD6AntiPersonnelMinefield = 27,
        MDI4IncendiaryMines = 28,
        AMG43MachineGunSentry = 29,
        AG16GatlingSentry = 30,
        AM12MortarSentry = 31,
        AAC8AutocannonSentry = 32,
        AMLS4XRocketSentry = 33,
        AM23EMSMortarSentry = 34,
        OrbitalGatlingBarrage = 35,
        OrbitalAirburstStrike = 36,
        Orbital120MMHEBarrage = 37,
        Orbital380MMHEBarrage = 38,
        OrbitalWalkingBarrage = 39,
        OrbitalLaser = 40,
        OrbitalRailcannonStrike = 41,
        OrbitalPrecisionStrike = 42,
        OrbitalGasStrike = 43,
        OrbitalEMSStrike = 44,
        OrbitalSmokeStrike = 45,
        EagleStrafingRun = 46,
        EagleAirstrike = 47,
        EagleClusterBomb = 48,
        EagleNapalmAirstrike = 49,
        EagleSmokeStrike = 50,
        Eagle110MMRocketPods = 51,
        Eagle500kgBomb = 52,
        Resupply = 53,
        EagleRearm = 54
    }

    internal class Stratagem
    {
        public static string GetIconImage(StratagemId stratagemId)
        {
            //switch statement for all the stratagemid enum
            switch (stratagemId)
            {
                case StratagemId.LIFT850JumpPack: return "imgs/icons/LIFT850JumpPack.png";
                case StratagemId.B1SupplyPack: return "imgs/icons/B1SupplyPack.png";
                case StratagemId.AXLAS5GuardDogRover: return "imgs/icons/AXLAS5GuardDogRover.png";
                case StratagemId.SH20BallisticShieldBackpack: return "imgs/icons/SH20BallisticShieldBackpack.png";
                case StratagemId.SH32ShieldGeneratorPack: return "imgs/icons/SH32ShieldGeneratorPack.png";
                case StratagemId.AXAR23GuardDog: return "imgs/icons/AXAR23GuardDog.png";
                case StratagemId.MG43MachineGun: return "imgs/icons/MG43MachineGun.png";
                case StratagemId.APW1AntiMaterielRifle: return "imgs/icons/APW1AntiMaterielRifle.png";
                case StratagemId.M105Stalwart: return "imgs/icons/M105Stalwart.png";
                case StratagemId.EAT17ExpendableAntitank: return "imgs/icons/EAT17ExpendableAntitank.png";
                case StratagemId.GR8RecoillessRifle: return "imgs/icons/GR8RecoillessRifle.png";
                case StratagemId.FLAM40Flamethrower: return "imgs/icons/FLAM40Flamethrower.png";
                case StratagemId.AC8Autocannon: return "imgs/icons/AC8Autocannon.png";
                case StratagemId.MG206HeavyMachineGun: return "imgs/icons/MG206HeavyMachineGun.png";
                case StratagemId.RL77AirburstRocketLauncher: return "imgs/icons/RL77AirburstRocketLauncher.png";
                case StratagemId.MLS4XCommando: return "imgs/icons/MLS4XCommando.png";
                case StratagemId.RS422Railgun: return "imgs/icons/RS422Railgun.png";
                case StratagemId.FAF14SPEARLauncher: return "imgs/icons/FAF14SPEARLauncher.png";
                case StratagemId.GL21GrenadeLauncher: return "imgs/icons/GL21GrenadeLauncher.png";
                case StratagemId.LAS98LaserCannon: return "imgs/icons/LAS98LaserCannon.png";
                case StratagemId.ARC3ArcThrower: return "imgs/icons/ARC3ArcThrower.png";
                case StratagemId.LAS99QuasarCannon: return "imgs/icons/LAS99QuasarCannon.png";
                case StratagemId.EXO45PatriotExosuit: return "imgs/icons/EXO45PatriotExosuit.png";
                case StratagemId.EXO49EmancipatorExosuit: return "imgs/icons/EXO49EmancipatorExosuit.png";
                case StratagemId.EMG101HMGEmplacement: return "imgs/icons/EMG101HMGEmplacement.png";
                case StratagemId.FX12ShieldGeneratorRelay: return "imgs/icons/FX12ShieldGeneratorRelay.png";
                case StratagemId.AARC3TeslaTower: return "imgs/icons/AARC3TeslaTower.png";
                case StratagemId.MD6AntiPersonnelMinefield: return "imgs/icons/MD6AntiPersonnelMinefield.png";
                case StratagemId.MDI4IncendiaryMines: return "imgs/icons/MDI4IncendiaryMines.png";
                case StratagemId.AMG43MachineGunSentry: return "imgs/icons/AMG43MachineGunSentry.png";
                case StratagemId.AG16GatlingSentry: return "imgs/icons/AG16GatlingSentry.png";
                case StratagemId.AM12MortarSentry: return "imgs/icons/AM12MortarSentry.png";
                case StratagemId.AAC8AutocannonSentry: return "imgs/icons/AAC8AutocannonSentry.png";
                case StratagemId.AMLS4XRocketSentry: return "imgs/icons/AMLS4XRocketSentry.png";
                case StratagemId.AM23EMSMortarSentry: return "imgs/icons/AM23EMSMortarSentry.png";
                case StratagemId.OrbitalGatlingBarrage: return "imgs/icons/OrbitalGatlingBarrage.png";
                case StratagemId.OrbitalAirburstStrike: return "imgs/icons/OrbitalAirburstStrike.png";
                case StratagemId.Orbital120MMHEBarrage: return "imgs/icons/Orbital120MMHEBarrage.png";
                case StratagemId.Orbital380MMHEBarrage: return "imgs/icons/Orbital380MMHEBarrage.png";
                case StratagemId.OrbitalWalkingBarrage: return "imgs/icons/OrbitalWalkingBarrage.png";
                case StratagemId.OrbitalLaser: return "imgs/icons/OrbitalLaser.png";
                case StratagemId.OrbitalRailcannonStrike: return "imgs/icons/OrbitalRailcannonStrike.png";
                case StratagemId.OrbitalPrecisionStrike: return "Orbital/HD2-OPS.png";
                case StratagemId.OrbitalGasStrike: return "imgs/icons/OrbitalGasStrike.png";
                case StratagemId.OrbitalEMSStrike: return "imgs/icons/OrbitalEMSStrike.png";
                case StratagemId.OrbitalSmokeStrike: return "imgs/icons/OrbitalSmokeStrike.png";
                case StratagemId.EagleStrafingRun: return "imgs/icons/EagleStrafingRun.png";
                case StratagemId.EagleAirstrike: return "Eagle/HD2-EA.png";
                case StratagemId.EagleClusterBomb: return "imgs/icons/EagleClusterBomb.png";
                case StratagemId.EagleNapalmAirstrike: return "imgs/icons/EagleNapalmAirstrike.png";
                case StratagemId.EagleSmokeStrike: return "imgs/icons/EagleSmokeStrike.png";
                case StratagemId.Eagle110MMRocketPods: return "imgs/icons/Eagle110MMRocketPods.png";
                case StratagemId.Eagle500kgBomb: return "imgs/icons/Eagle500kgBomb.png";
                case StratagemId.Resupply: return "imgs/icons/Resupply.png";
                case StratagemId.EagleRearm: return "imgs/icons/EagleRearm.png";
                default: return "";
            }
        }

        public static string GetStratagemTitle(StratagemId stratagemId)
        {
            switch (stratagemId)
            {
                case StratagemId.LIFT850JumpPack: return "LIFT850JumpPack";
                case StratagemId.B1SupplyPack: return "B1SupplyPack";
                case StratagemId.AXLAS5GuardDogRover: return "AXLAS5GuardDogRover";
                case StratagemId.SH20BallisticShieldBackpack: return "SH20BallisticShieldBackpack";
                case StratagemId.SH32ShieldGeneratorPack: return "SH32ShieldGeneratorPack";
                case StratagemId.AXAR23GuardDog: return "AXAR23GuardDog";
                case StratagemId.MG43MachineGun: return "MG43MachineGun";
                case StratagemId.APW1AntiMaterielRifle: return "APW1AntiMaterielRifle";
                case StratagemId.M105Stalwart: return "M105Stalwart";
                case StratagemId.EAT17ExpendableAntitank: return "EAT17ExpendableAntitank";
                case StratagemId.GR8RecoillessRifle: return "GR8RecoillessRifle";
                case StratagemId.FLAM40Flamethrower: return "FLAM40Flamethrower";
                case StratagemId.AC8Autocannon: return "AC8Autocannon";
                case StratagemId.MG206HeavyMachineGun: return "MG206HeavyMachineGun";
                case StratagemId.RL77AirburstRocketLauncher: return "RL77AirburstRocketLauncher";
                case StratagemId.MLS4XCommando: return "MLS4XCommando";
                case StratagemId.RS422Railgun: return "RS422Railgun";
                case StratagemId.FAF14SPEARLauncher: return "FAF14SPEARLauncher";
                case StratagemId.GL21GrenadeLauncher: return "GL21GrenadeLauncher";
                case StratagemId.LAS98LaserCannon: return "LAS98LaserCannon";
                case StratagemId.ARC3ArcThrower: return "ARC3ArcThrower";
                case StratagemId.LAS99QuasarCannon: return "LAS99QuasarCannon";
                case StratagemId.EXO45PatriotExosuit: return "EXO45PatriotExosuit";
                case StratagemId.EXO49EmancipatorExosuit: return "EXO49EmancipatorExosuit";
                case StratagemId.EMG101HMGEmplacement: return "EMG101HMGEmplacement";
                case StratagemId.FX12ShieldGeneratorRelay: return "FX12ShieldGeneratorRelay";
                case StratagemId.AARC3TeslaTower: return "AARC3TeslaTower";
                case StratagemId.MD6AntiPersonnelMinefield: return "MD6AntiPersonnelMinefield";
                case StratagemId.MDI4IncendiaryMines: return "MDI4IncendiaryMines";
                case StratagemId.AMG43MachineGunSentry: return "AMG43MachineGunSentry";
                case StratagemId.AG16GatlingSentry: return "AG16GatlingSentry";
                case StratagemId.AM12MortarSentry: return "AM12MortarSentry";
                case StratagemId.AAC8AutocannonSentry: return "AAC8AutocannonSentry";
                case StratagemId.AMLS4XRocketSentry: return "AMLS4XRocketSentry";
                case StratagemId.AM23EMSMortarSentry: return "AM23EMSMortarSentry";
                case StratagemId.OrbitalGatlingBarrage: return "OrbitalGatlingBarrage";
                case StratagemId.OrbitalAirburstStrike: return "OrbitalAirburstStrike";
                case StratagemId.Orbital120MMHEBarrage: return "Orbital120MMHEBarrage";
                case StratagemId.Orbital380MMHEBarrage: return "Orbital380MMHEBarrage";
                case StratagemId.OrbitalWalkingBarrage: return "OrbitalWalkingBarrage";
                case StratagemId.OrbitalLaser: return "OrbitalLaser";
                case StratagemId.OrbitalRailcannonStrike: return "OrbitalRailcannonStrike";
                case StratagemId.OrbitalPrecisionStrike: return "Orbital\nPrecision\nStrike";
                case StratagemId.OrbitalGasStrike: return "OrbitalGasStrike";
                case StratagemId.OrbitalEMSStrike: return "OrbitalEMSStrike";
                case StratagemId.OrbitalSmokeStrike: return "OrbitalSmokeStrike";
                case StratagemId.EagleStrafingRun: return "EagleStrafingRun";
                case StratagemId.EagleAirstrike: return "Eagle\nAirstrike";
                case StratagemId.EagleClusterBomb: return "EagleClusterBomb";
                case StratagemId.EagleNapalmAirstrike: return "EagleNapalmAirstrike";
                case StratagemId.EagleSmokeStrike: return "EagleSmokeStrike";
                case StratagemId.Eagle110MMRocketPods: return "Eagle110MMRocketPods";
                case StratagemId.Eagle500kgBomb: return "Eagle500kgBomb";
                case StratagemId.Resupply: return "Resupply";
                case StratagemId.EagleRearm: return "EagleRearm";
                default: return "";
            }
        }



        public static string GetStratagemButtons(StratagemId stratagemId)
        {
            switch (stratagemId)
            {
                case StratagemId.LIFT850JumpPack: return "LIFT850JumpPack";
                case StratagemId.B1SupplyPack: return "B1SupplyPack";
                case StratagemId.AXLAS5GuardDogRover: return "AXLAS5GuardDogRover";
                case StratagemId.SH20BallisticShieldBackpack: return "SH20BallisticShieldBackpack";
                case StratagemId.SH32ShieldGeneratorPack: return "SH32ShieldGeneratorPack";
                case StratagemId.AXAR23GuardDog: return "AXAR23GuardDog";
                case StratagemId.MG43MachineGun: return "dldur";
                case StratagemId.APW1AntiMaterielRifle: return "APW1AntiMaterielRifle";
                case StratagemId.M105Stalwart: return "M105Stalwart";
                case StratagemId.EAT17ExpendableAntitank: return "EAT17ExpendableAntitank";
                case StratagemId.GR8RecoillessRifle: return "GR8RecoillessRifle";
                case StratagemId.FLAM40Flamethrower: return "FLAM40Flamethrower";
                case StratagemId.AC8Autocannon: return "AC8Autocannon";
                case StratagemId.MG206HeavyMachineGun: return "MG206HeavyMachineGun";
                case StratagemId.RL77AirburstRocketLauncher: return "RL77AirburstRocketLauncher";
                case StratagemId.MLS4XCommando: return "MLS4XCommando";
                case StratagemId.RS422Railgun: return "RS422Railgun";
                case StratagemId.FAF14SPEARLauncher: return "FAF14SPEARLauncher";
                case StratagemId.GL21GrenadeLauncher: return "GL21GrenadeLauncher";
                case StratagemId.LAS98LaserCannon: return "LAS98LaserCannon";
                case StratagemId.ARC3ArcThrower: return "ARC3ArcThrower";
                case StratagemId.LAS99QuasarCannon: return "LAS99QuasarCannon";
                case StratagemId.EXO45PatriotExosuit: return "EXO45PatriotExosuit";
                case StratagemId.EXO49EmancipatorExosuit: return "EXO49EmancipatorExosuit";
                case StratagemId.EMG101HMGEmplacement: return "EMG101HMGEmplacement";
                case StratagemId.FX12ShieldGeneratorRelay: return "FX12ShieldGeneratorRelay";
                case StratagemId.AARC3TeslaTower: return "AARC3TeslaTower";
                case StratagemId.MD6AntiPersonnelMinefield: return "MD6AntiPersonnelMinefield";
                case StratagemId.MDI4IncendiaryMines: return "MDI4IncendiaryMines";
                case StratagemId.AMG43MachineGunSentry: return "AMG43MachineGunSentry";
                case StratagemId.AG16GatlingSentry: return "AG16GatlingSentry";
                case StratagemId.AM12MortarSentry: return "AM12MortarSentry";
                case StratagemId.AAC8AutocannonSentry: return "AAC8AutocannonSentry";
                case StratagemId.AMLS4XRocketSentry: return "AMLS4XRocketSentry";
                case StratagemId.AM23EMSMortarSentry: return "AM23EMSMortarSentry";
                case StratagemId.OrbitalGatlingBarrage: return "OrbitalGatlingBarrage";
                case StratagemId.OrbitalAirburstStrike: return "OrbitalAirburstStrike";
                case StratagemId.Orbital120MMHEBarrage: return "Orbital120MMHEBarrage";
                case StratagemId.Orbital380MMHEBarrage: return "Orbital380MMHEBarrage";
                case StratagemId.OrbitalWalkingBarrage: return "OrbitalWalkingBarrage";
                case StratagemId.OrbitalLaser: return "OrbitalLaser";
                case StratagemId.OrbitalRailcannonStrike: return "OrbitalRailcannonStrike";
                case StratagemId.OrbitalPrecisionStrike: return "rru";
                case StratagemId.OrbitalGasStrike: return "OrbitalGasStrike";
                case StratagemId.OrbitalEMSStrike: return "OrbitalEMSStrike";
                case StratagemId.OrbitalSmokeStrike: return "OrbitalSmokeStrike";
                case StratagemId.EagleStrafingRun: return "EagleStrafingRun";
                case StratagemId.EagleAirstrike: return "urdr";
                case StratagemId.EagleClusterBomb: return "EagleClusterBomb";
                case StratagemId.EagleNapalmAirstrike: return "EagleNapalmAirstrike";
                case StratagemId.EagleSmokeStrike: return "EagleSmokeStrike";
                case StratagemId.Eagle110MMRocketPods: return "Eagle110MMRocketPods";
                case StratagemId.Eagle500kgBomb: return "Eagle500kgBomb";
                case StratagemId.Resupply: return "Resupply";
                case StratagemId.EagleRearm: return "EagleRearm";
                default: return "";
            }
        }
    }
}