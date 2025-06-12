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
        EagleRearm = 54,
        Reinforce = 55,
        SOSBeacon = 56,
        HellBomb = 57,
        SEAFArtillery = 58,
        MD8GasMines = 59,
        AntiTankEmplacement = 60,
        AntiTankMines = 61,
        GrenadierBattlement = 62,
        HoverPack = 63,
        WASPLauncher = 64,
        FastReconVehicle = 65,
        DirectionalShieldBackpack = 66,
        GuardDogDogBreath = 67,
        PortableHellbomb = 68
    }

    internal class Stratagem
    {
        public static string GetIconImage(StratagemId stratagemId)
        {
            //switch statement for all the stratagemid enum
            switch (stratagemId)
            {
                case StratagemId.SH20BallisticShieldBackpack: return "Packs/HD2-BS";
                case StratagemId.DirectionalShieldBackpack: return "Packs/HD2-DS";
                case StratagemId.AXAR23GuardDog: return "Packs/HD2-GD";
                case StratagemId.GuardDogDogBreath: return "Packs/HD2-GDDB";
                case StratagemId.AXLAS5GuardDogRover: return "Packs/HD2-GDR";
                case StratagemId.HoverPack: return "Packs/HD2-HP";
                case StratagemId.LIFT850JumpPack: return "Packs/HD2-JP";
                case StratagemId.PortableHellbomb: return "Packs/HD2-PHB";
                case StratagemId.SH32ShieldGeneratorPack: return "Packs/HD2-SGP";
                case StratagemId.B1SupplyPack: return "Packs/HD2-SP";

                case StratagemId.EXO45PatriotExosuit: return "Vehicles/HD2-EXO2";
                case StratagemId.EXO49EmancipatorExosuit: return "Vehicles/HD2-EXO2";
                case StratagemId.FastReconVehicle: return "Vehicles/HD2-FRV";

                case StratagemId.MG43MachineGun: return "Weapons/HD2-MG";
                case StratagemId.APW1AntiMaterielRifle: return "Weapons/HD2-AMR";
                case StratagemId.M105Stalwart: return "Weapons/HD2-STA";
                case StratagemId.EAT17ExpendableAntitank: return "Weapons/HD2-EAT";
                case StratagemId.GR8RecoillessRifle: return "Weapons/HD2-RR";
                case StratagemId.FLAM40Flamethrower: return "Weapons/HD2-FT";
                case StratagemId.AC8Autocannon: return "Weapons/HD2-AC";
                case StratagemId.MG206HeavyMachineGun: return "Weapons/HD2-HMG";
                case StratagemId.RL77AirburstRocketLauncher: return "Weapons/HD2-ABR";
                case StratagemId.MLS4XCommando: return "Weapons/HD2-MLS";
                case StratagemId.RS422Railgun: return "Weapons/HD2-RG";
                case StratagemId.FAF14SPEARLauncher: return "Weapons/HD2-SPE";
                case StratagemId.GL21GrenadeLauncher: return "Weapons/HD2-GL";
                case StratagemId.LAS98LaserCannon: return "Weapons/HD2-LC";
                case StratagemId.ARC3ArcThrower: return "Weapons/HD2-AT";
                case StratagemId.LAS99QuasarCannon: return "Weapons/HD2-QC";
                case StratagemId.WASPLauncher: return "Weapons/HD2-WAS";

                case StratagemId.MD6AntiPersonnelMinefield: return "Emplacements/HD2-APM";
                case StratagemId.AntiTankEmplacement: return "Emplacements/HD2-ATE";
                case StratagemId.AntiTankMines: return "Emplacements/HD2-ATM";
                case StratagemId.GrenadierBattlement: return "Emplacements/HD2-GRB";
                case StratagemId.EMG101HMGEmplacement: return "Emplacements/HD2-HMGT";
                case StratagemId.MDI4IncendiaryMines: return "Emplacements/HD2-IM";
                case StratagemId.MD8GasMines: return "Emplacements/HD2-MD8";
                case StratagemId.FX12ShieldGeneratorRelay: return "Emplacements/HD2-SG";
                case StratagemId.AARC3TeslaTower: return "Emplacements/HD2-TT";

                case StratagemId.AMG43MachineGunSentry: return "Emplacements/HD2-";
                case StratagemId.AG16GatlingSentry: return "Emplacements/HD2-";
                case StratagemId.AM12MortarSentry: return "Emplacements/HD2-";
                case StratagemId.AAC8AutocannonSentry: return "Emplacements/HD2-";
                case StratagemId.AMLS4XRocketSentry: return "Emplacements/HD2-";
                case StratagemId.AM23EMSMortarSentry: return "Emplacements/HD2-";

                case StratagemId.OrbitalGatlingBarrage: return "Orbital/HD2-EGB";
                case StratagemId.Orbital120MMHEBarrage: return "Orbital/HD2-O120";
                case StratagemId.Orbital380MMHEBarrage: return "Orbital/HD2-O380";
                case StratagemId.OrbitalAirburstStrike: return "Orbital/HD2-OAS";
                case StratagemId.OrbitalEMSStrike: return "Orbital/HD2-OES";
                case StratagemId.OrbitalGasStrike: return "Orbital/HD2-OGS";
                case StratagemId.OrbitalLaser: return "Orbital/HD2-OL";
                //napalm ONB
                case StratagemId.OrbitalPrecisionStrike: return "Orbital/HD2-OPS";
                case StratagemId.OrbitalRailcannonStrike: return "Orbital/HD2-ORS";
                case StratagemId.OrbitalSmokeStrike: return "Orbital/HD2-OSS";
                case StratagemId.OrbitalWalkingBarrage: return "Orbital/HD2-OWB";

                case StratagemId.EagleStrafingRun: return "Eagle/HD2-ESR";
                case StratagemId.EagleClusterBomb: return "Eagle/HD2-ECB";
                case StratagemId.EagleNapalmAirstrike: return "Eagle/HD2-ENA";
                case StratagemId.EagleSmokeStrike: return "Eagle/HD2-ESS";
                case StratagemId.Eagle110MMRocketPods: return "Eagle/HD2-E110";
                case StratagemId.Eagle500kgBomb: return "Eagle/HD2-E500";
                case StratagemId.EagleRearm: return "Eagle/HD2-ERA";

                case StratagemId.EagleAirstrike: return "Eagle/HD2-EA";

                case StratagemId.HellBomb: return "Mission/HD2-Hellbomb";
                //prospect drill
                case StratagemId.Reinforce: return "Mission/HD2-Reinforcement";
                case StratagemId.Resupply: return "Mission/HD2-Resupply";
                case StratagemId.SEAFArtillery: return "Mission/HD2-SEAF-ALT";
                //super earth flag
                //seismic probe
                case StratagemId.SOSBeacon: return "Mission/HD2-SOS";
                //upload data

                default: return "";
            }
        }

        public static string GetStratagemTitle(StratagemId stratagemId)
        {
            switch (stratagemId)
            {
                case StratagemId.LIFT850JumpPack: return "LIFT\n850\nJumpPack";
                case StratagemId.B1SupplyPack: return "B1\nSupply\nPack";
                case StratagemId.AXLAS5GuardDogRover: return "AXLAS5\nGuard Dog\nRover";
                case StratagemId.SH20BallisticShieldBackpack: return "SH20\nBallistic\nShield\nBackpack";
                case StratagemId.SH32ShieldGeneratorPack: return "SH32\nShield\nGenerator\nPack";
                case StratagemId.AXAR23GuardDog: return "AXAR23\nGuard Dog";
                case StratagemId.MG43MachineGun: return "MG43\nMachineGun";
                case StratagemId.APW1AntiMaterielRifle: return "APW1\nAnti Materiel\nRifle";
                case StratagemId.M105Stalwart: return "M105\nStalwart";
                case StratagemId.EAT17ExpendableAntitank: return "EAT17\nExpendable\nAnti tank";
                case StratagemId.GR8RecoillessRifle: return "GR8\nRecoilless\nRifle";
                case StratagemId.FLAM40Flamethrower: return "FLAM40\nFlamethrower";
                case StratagemId.AC8Autocannon: return "Autocannon";
                case StratagemId.MG206HeavyMachineGun: return "Heavy\nMachineGun";
                case StratagemId.RL77AirburstRocketLauncher: return "Airburst\nRocket\nLauncher";
                case StratagemId.MLS4XCommando: return "Commando";
                case StratagemId.RS422Railgun: return "Railgun";
                case StratagemId.FAF14SPEARLauncher: return "SPEAR\nLauncher";
                case StratagemId.GL21GrenadeLauncher: return "Grenade\nLauncher";
                case StratagemId.LAS98LaserCannon: return "Laser\nCannon";
                case StratagemId.ARC3ArcThrower: return "Arc\nThrower";
                case StratagemId.LAS99QuasarCannon: return "Quasar\nCannon";
                case StratagemId.EXO45PatriotExosuit: return "Patriot\nExosuit";
                case StratagemId.EXO49EmancipatorExosuit: return "Emancipator\nExosuit";
                case StratagemId.EMG101HMGEmplacement: return "HMG\nEmplacement";
                case StratagemId.FX12ShieldGeneratorRelay: return "Shield\nGenerator\nRelay";
                case StratagemId.AARC3TeslaTower: return "Tesla\nTower";
                case StratagemId.MD6AntiPersonnelMinefield: return "AntiPersonnel\nMinefield";
                case StratagemId.MDI4IncendiaryMines: return "Incendiary\nMines";
                case StratagemId.AMG43MachineGunSentry: return "MachineGun\nSentry";
                case StratagemId.AG16GatlingSentry: return "Gatling\nSentry";
                case StratagemId.AM12MortarSentry: return "Mortar\nSentry";
                case StratagemId.AAC8AutocannonSentry: return "Autocannon\nSentry";
                case StratagemId.AMLS4XRocketSentry: return "Rocket\nSentry";
                case StratagemId.AM23EMSMortarSentry: return "Mortar\nSentry";
                case StratagemId.OrbitalGatlingBarrage: return "Orbital\nGatling\nBarrage";
                case StratagemId.OrbitalAirburstStrike: return "Orbital\nAirburst\nStrike";
                case StratagemId.Orbital120MMHEBarrage: return "Orbital\n120MMHE\nBarrage";
                case StratagemId.Orbital380MMHEBarrage: return "Orbital\n380MMHE\nBarrage";
                case StratagemId.OrbitalWalkingBarrage: return "Orbital\nWalking\nBarrage";
                case StratagemId.OrbitalLaser: return "Orbital\nLaser";
                case StratagemId.OrbitalRailcannonStrike: return "Orbital\nRailcannon\nStrike";
                case StratagemId.OrbitalPrecisionStrike: return "Orbital\nPrecision\nStrike";
                case StratagemId.OrbitalGasStrike: return "Orbital\nGas\nStrike";
                case StratagemId.OrbitalEMSStrike: return "Orbital\nEMS\nStrike";
                case StratagemId.OrbitalSmokeStrike: return "Orbital\nSmoke\nStrike";
                case StratagemId.EagleStrafingRun: return "Eagle\nStrafing\nRun";
                case StratagemId.EagleAirstrike: return "Eagle\nAirstrike";
                case StratagemId.EagleClusterBomb: return "Eagle\nCluster\nBomb";
                case StratagemId.EagleNapalmAirstrike: return "Eagle\nNapalm\nAirstrike";
                case StratagemId.EagleSmokeStrike: return "Eagle\nSmoke\nStrike";
                case StratagemId.Eagle110MMRocketPods: return "Eagle\n110MM\nRocketPods";
                case StratagemId.Eagle500kgBomb: return "Eagle\n500kgBomb";
                case StratagemId.Resupply: return "Resupply";
                case StratagemId.EagleRearm: return "Eagle\nRearm";
                case StratagemId.Reinforce: return "Reinforce";
                case StratagemId.SOSBeacon: return "SOS\nBeacon";
                case StratagemId.HellBomb: return "Hellbomb";
                case StratagemId.SEAFArtillery: return "SEAF\nArtillery";
                case StratagemId.MD8GasMines: return "Gas Mines";
                case StratagemId.AntiTankEmplacement: return "Anti Tank\nEmplacement";
                case StratagemId.AntiTankMines: return "Anti Tank\nMines";
                case StratagemId.GrenadierBattlement: return "Grenadier Battlement";
                case StratagemId.HoverPack: return "Hover Pack";
                case StratagemId.WASPLauncher: return "WASP\nLauncher";
                case StratagemId.FastReconVehicle: return "Fast\nRecon";
                case StratagemId.DirectionalShieldBackpack: return "Directional\nShield";
                case StratagemId.GuardDogDogBreath: return "Dog\nBreath";
                case StratagemId.PortableHellbomb: return "Portable\nHellbomb";
                default: return "";
            }
        }

        public static string GetStratagemButtons(StratagemId stratagemId)
        {
            switch (stratagemId)
            {
                case StratagemId.LIFT850JumpPack: return "duudu";
                case StratagemId.B1SupplyPack: return "dlduud";
                case StratagemId.AXLAS5GuardDogRover: return "dulurr";
                case StratagemId.SH20BallisticShieldBackpack: return "dlddul";
                case StratagemId.SH32ShieldGeneratorPack: return "dulrlr";
                case StratagemId.AXAR23GuardDog: return "dulurd";
                case StratagemId.APW1AntiMaterielRifle: return "dlrud";
                case StratagemId.M105Stalwart: return "dlduul";
                case StratagemId.EAT17ExpendableAntitank: return "ddlur";
                case StratagemId.GR8RecoillessRifle: return "dlrrl";
                case StratagemId.FLAM40Flamethrower: return "dludu";
                case StratagemId.AC8Autocannon: return "dlduur";
                case StratagemId.MG206HeavyMachineGun: return "dludd";
                case StratagemId.RL77AirburstRocketLauncher: return "duulr";
                case StratagemId.MLS4XCommando: return "dludr";
                case StratagemId.RS422Railgun: return "drdulr";
                case StratagemId.FAF14SPEARLauncher: return "ddudd";
                case StratagemId.WASPLauncher: return "ddudr";

                case StratagemId.GL21GrenadeLauncher: return "dluld";
                case StratagemId.LAS98LaserCannon: return "dldul";
                case StratagemId.ARC3ArcThrower: return "drdull";
                case StratagemId.LAS99QuasarCannon: return "ddulr";
                case StratagemId.EXO45PatriotExosuit: return "ldruldd";

                case StratagemId.EXO49EmancipatorExosuit: return "ldruldu";

                case StratagemId.EMG101HMGEmplacement: return "dulrrl";
                case StratagemId.FX12ShieldGeneratorRelay: return "ddlrlr";
                case StratagemId.AARC3TeslaTower: return "durulr";

                case StratagemId.MD6AntiPersonnelMinefield: return "dlur";
                case StratagemId.MDI4IncendiaryMines: return "dlld";
                case StratagemId.AMG43MachineGunSentry: return "durru";
                case StratagemId.AG16GatlingSentry: return "durl";
                case StratagemId.AM12MortarSentry: return "durrd";
                case StratagemId.AAC8AutocannonSentry: return "durulu";
                case StratagemId.AMLS4XRocketSentry: return "durrl";
                case StratagemId.AM23EMSMortarSentry: return "durdr";

                case StratagemId.OrbitalGatlingBarrage: return "rdluu";
                case StratagemId.OrbitalAirburstStrike: return "rrr";
                case StratagemId.Orbital120MMHEBarrage: return "rrdlrd";
                case StratagemId.Orbital380MMHEBarrage: return "rduuldd";
                case StratagemId.OrbitalWalkingBarrage: return "rdrdrd";
                case StratagemId.OrbitalLaser: return "rdurd";
                case StratagemId.OrbitalRailcannonStrike: return "ruddr";
                case StratagemId.OrbitalGasStrike: return "rrdr";
                case StratagemId.OrbitalEMSStrike: return "rrld";
                case StratagemId.OrbitalSmokeStrike: return "rrdu";

                case StratagemId.EagleStrafingRun: return "urr";
                case StratagemId.EagleClusterBomb: return "urddr";
                case StratagemId.EagleNapalmAirstrike: return "urdu";
                case StratagemId.EagleSmokeStrike: return "urud";
                case StratagemId.Eagle110MMRocketPods: return "urul";
                case StratagemId.Eagle500kgBomb: return "urddd";

                case StratagemId.Resupply: return "ddur";
                case StratagemId.EagleRearm: return "uulur";
                case StratagemId.EagleAirstrike: return "urdr";
                case StratagemId.OrbitalPrecisionStrike: return "rru";
                case StratagemId.MG43MachineGun: return "dldur";
                case StratagemId.Reinforce: return "udrlu";
                case StratagemId.SOSBeacon: return "udru";
                case StratagemId.HellBomb: return "duldurdu";
                case StratagemId.SEAFArtillery: return "ruud";
                case StratagemId.MD8GasMines: return "dllr";
                case StratagemId.AntiTankEmplacement: return "dulrrr";
                case StratagemId.AntiTankMines: return "dluu";
                case StratagemId.GrenadierBattlement: return "drdlr";
                case StratagemId.HoverPack: return "duudlr";
                case StratagemId.FastReconVehicle: return "ldrdrdu";
                case StratagemId.DirectionalShieldBackpack: return "dulruu";
                case StratagemId.GuardDogDogBreath: return "duluru";
                case StratagemId.PortableHellbomb: return "druuu";
                default: return "";
            }
        }
    }
}