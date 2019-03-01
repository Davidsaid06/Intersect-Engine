﻿using Intersect.Localization;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Intersect.Server.Core.CommandParsing;

namespace Intersect.Server.Localization
{
    public static partial class Strings
    {
        public sealed class CommandsNamespace : LocaleCommandNamespace
        {
            public sealed class ArgumentsNamespace : LocaleNamespace
            {
                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument Help = new LocaleArgument
                {
                    Name = @"help",
                    ShortName = 'h',
                    Description = @"shows this help message"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument AccessBoolean = new LocaleArgument
                {
                    Name = @"access",
                    Description = @"whether or not to grant/revoke access"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument AnnouncementMessage = new LocaleArgument
                {
                    Name = @"message",
                    Description = @"the message to send"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument CpsOperation = new LocaleArgument
                {
                    Name = @"operation",
                    Description = @"one of the following: status, lock, unlock"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocalizedString CpsLock = @"lock";

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocalizedString CpsStatus = @"status";

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocalizedString CpsUnlock = @"unlock";

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument DurationBan = new LocaleArgument
                {
                    Name = @"duration",
                    Description = @"the duration to ban"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument DurationMute = new LocaleArgument
                {
                    Name = @"duration",
                    Description = @"the duration to mute"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument IpBan = new LocaleArgument
                {
                    Name = @"ip-ban",
                    Description = @"if it is an IP ban"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument IpMute = new LocaleArgument
                {
                    Name = @"ip-ban",
                    Description = @"if it is an IP mute"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument Power = new LocaleArgument
                {
                    Name = @"access",
                    Description = @"the access level to assign"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument ReasonBan = new LocaleArgument
                {
                    Name = @"reason",
                    Description = @"the reason for the ban"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument ReasonMute = new LocaleArgument
                {
                    Name = @"reason",
                    Description = @"the reason for the mute"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetApi = new LocaleArgument
                {
                    Name = @"account-name",
                    Description = @"the name of the acount to change the API access of"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetKick = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to kick"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetKill = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to kill"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetBan = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to ban"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetMute = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to mute"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetPower = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to change the access of"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetPowerAccount = new LocaleArgument
                {
                    Name = @"account-name",
                    Description = @"the name of the acount to change the access of"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetUnban = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to unban"
                };

                [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
                public readonly LocaleArgument TargetUnmute = new LocaleArgument
                {
                    Name = @"player-name",
                    Description = @"the name of the player to unmute"
                };
            }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly ArgumentsNamespace Arguments = new ArgumentsNamespace();

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly CommandParsingNamespace Parsing = new CommandParsingNamespace();

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString FlagInfo = @"(flag)";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString RequiredInfo = @"(required)";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString exiting =
                @"Server is now closing. Please wait while your game and player data is saved!";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString commandinfo = @"/?";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString invalid = @"Invalid /command.";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString madeprivate =
                @"The server has now been made private and can only be accessed by admins. To change this use the makepublic command or edit the adminonly field in config.json";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString madepublic =
                @"The server has now been made public and can be accessed by all players. To change this use the makepublic command or edit the adminonly field in config.json";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString banuser = @"console";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocalizedString muteuser = @"console";

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Announcement = new LocaleCommand
            {
                Name = @"announcement",
                Description = @"Sends a global message to all users playing the game.",
                Help = @"sends a global message to all players",
                Usage = @"Usage: announcement [message] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Api = new LocaleCommand
            {
                Name = @"api",
                Description =
                    @"Sets the api access (enabled/disabled) of a selected account. 1 is enabled, 0 is disabled",
                Help = @"enables or disables api access for an account",
                Usage = @"Usage: api [account] [1/0]"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Ban = new LocaleCommand
            {
                Name = @"ban",
                Description = @"Bans a player from the server.",
                Help = @"bans a player from the server",
                Usage = @"Usage: ban [username] [duration (days)] [IP Ban? ({00}/{01})] [reason] {02}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Cps = new LocaleCommand
            {
                Name = @"cps",
                Description =
                    @"Prints the current CPS. The status flag tells if the server loop is locked or unlocked. The lock flag locks the cps while the unlock flag unlocks it.",
                Help = @"prints the current server cps",
                Usage = @"Usage: cps [status|lock|unlock] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Exit = new LocaleCommand
            {
                Name = @"exit",
                Description = @"Closes down the server.",
                Help = @"closes the server",
                Usage = @"Usage: exit {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Help = new LocaleCommand
            {
                Name = @"help",
                Description = @"help",
                Help = @"displays list of available commands",
                Usage = @"help"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Kick = new LocaleCommand
            {
                Name = @"kick",
                Description = @"Kicks a player from the server.",
                Help = @"kicks a player from the server",
                Usage = @"Usage: kick [username] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Kill = new LocaleCommand
            {
                Name = @"kill",
                Description = @"Kills a player on the server.",
                Help = @"kills a player on the server",
                Usage = @"Usage: kill [username] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand MakePrivate = new LocaleCommand
            {
                Name = @"makeprivate",
                Description = @"Makes the server private and can only be accessed by admins.",
                Help = @"Makes the server private and can only be accessed by admins.",
                Usage = @"Usage: makeprivate"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand MakePublic = new LocaleCommand
            {
                Name = @"makepublic",
                Description = @"Makes the server public to all players.",
                Help = @"Makes the server public to all players.",
                Usage = @"Usage: makepublic"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Migrate = new LocaleCommand
            {
                Name = @"migrate",
                Description =
                    @"Walks you through migrating your player or game database between sqlite and mysql.",
                Help = @"walks you through migrating your player or game database between sqlite and mysql",
                Usage = @"Usage: migrate"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Mute = new LocaleCommand
            {
                Name = @"mute",
                Description = @"mutes a player preventing them from talking.",
                Help = @"mutes a player preventing them from talking",
                Usage = @"Usage: mute [username] [duration (days)] [IP Ban? ({00}/{01})] [reason] {02}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand NetDebug = new LocaleCommand
            {
                Name = @"netdebug",
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand OnlineList = new LocaleCommand
            {
                Name = @"onlinelist",
                Help = @"shows all players online"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Power = new LocaleCommand
            {
                Name = @"power",
                Description =
                    @"Sets the power or access of a selected account. Power 0 is regular user. Power 1 is in-game moderator. Power 2 is owner/designer and allows editor access.",
                Help = @"sets the administrative access of a user",
                Usage = @"Usage: power [username] [level] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand PowerAccount = new LocaleCommand
            {
                Name = @"poweracc",
                Description =
                    @"Sets the power or access of a selected account. Power 0 is regular user. Power 1 is in-game moderator. Power 2 is owner/designer and allows editor access.",
                Help = @"sets the administrative access of an account",
                Usage = @"Usage: power [login] [level] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Unban = new LocaleCommand
            {
                Name = @"unban",
                Description = @"Unbans a player from the server.",
                Help = @"unbans a player from the server",
                Usage = @"Usage: unban [account] {00}"
            };

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] [NotNull]
            public readonly LocaleCommand Unmute = new LocaleCommand
            {
                Name = @"unmute",
                Description = @"unmutes a player allowing them to talk.",
                Help = @"unmutes a player allowing them to talk",
                Usage = @"Usage: unmute [username] {00}"
            };
        }
    }
}