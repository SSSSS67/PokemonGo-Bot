using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using PokemonGo.RocketAPI.Enums;
using System.Collections.Generic;
using System.Device.Location;

namespace PokemonGo.RocketAPI
{
    public interface ISettings
    {
        AuthType AuthType { get; }
        double DefaultLatitude { get; }
        double DefaultLongitude { get; }
        double DefaultAltitude { get; }
        string GoogleRefreshToken { get; set; }
        string PtcPassword { get; }
        string PtcUsername { get; }
        string GoogleUsername { get; }
        string GooglePassword { get; }

        bool UseLastCords { get; }

        bool WalkBackToDefaultLocation { get; }
        int MaxWalkingRadiusInMeters { get; }
        int HoldMaxDoublePokemons { get; }

        int TelegramLiveStatsDelay { get; }

        double WalkingSpeedInKilometerPerHour { get; }

        bool EvolvePokemonsIfEnoughCandy { get; }
        bool TransferDoublePokemons { get; }

        int DontTransferWithCPOver { get; }
        int ivmaxpercent { get; }

        bool sleepatpokemons { get; }

        string TelegramAPIToken { get; }
        string TelegramName { get; }

        int navigation_option { get; }

        bool UseLuckyEgg { get; }
        bool UseRazzBerry { get; }
        double razzberry_chance { get; }
        bool UseLuckyEggIfNotRunning { get; }
        bool keepPokemonsThatCanEvolve { get; }
        bool TransferFirstLowIV { get; }
        bool UseIncense { get; }

        bool AutoIncubate { get; }
        bool UseBasicIncubators { get; }

        bool pokevision { get; }
          
        //Proxies
        string UseProxyHost { get; set; }
        int UseProxyPort { get; set; }
        string UseProxyUsername { get; set; }
        string UseProxyPassword { get; set; }

        bool UseProxyVerified { get; set; }
        bool UseProxyAuthentication { get; set; }

        ICollection<KeyValuePair<ItemId, int>> itemRecycleFilter { get; set; }

        List<PokemonId> pokemonsToHold { get; set; }
        List<PokemonId> pokemonsToEvolve { get; set; }
        List<PokemonId> catchPokemonSkipList { get; }


        string SelectedLanguage { get; }
        string GoogleMapsAPIKey { get; }
        bool pauseAtPokeStop { get; set; }
        bool FarmPokestops { get; set; }
        bool CatchPokemon { get; set; }
        bool BreakAtLure { get; set; }
        bool UseLureAtBreak { get; set; }
        bool UseGoogleMapsAPI { get; set; }
        bool UseAnimationTimes { get; set; }
        bool RandomReduceSpeed { get; set; }
        bool UseBreakFields { get; set; }
        double TimeToRun { get; set; }
        int PokemonCatchLimit { get; set; }
        int PokestopFarmLimit { get; set; }
        int XPFarmedLimit { get; set; }
        int BreakInterval { get; set; }
        int BreakLength { get; set; }
        int MinWalkSpeed { get; set; }
        bool Espiral { get;  set; }
        bool MapLoaded { get; set; }
        Queue<GeoCoordinate> NextDestinationOverride { get; set; }
        Queue<GeoCoordinate> RouteToRepeat { get; set; }
        bool logPokemons { get; set; }
        bool logManualTransfer { get; set; }

        bool UseLureGUIClick { get; set; }
        bool UseIncenseGUIClick { get; set; }
        bool UseLuckyEggGUIClick { get; set; }
        bool RepeatUserRoute { get; set; }

        bool bLogEvolve { get; set; }

        bool pauseTheWalking { get; set; }

        bool pauseAtEvolve2 { get; set; }
    }
}
