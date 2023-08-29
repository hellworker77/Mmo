namespace Entities.Enums;

public enum GuildActionType
{
    Invite, InviteViaLink,
    Mute, UnMute, MuteExempt,
    Ban, UnBan, BanExempt,
    Kick, KickExempt,
    Promote, PromoteViaLink,
    DeleteMessages, DeleteMessageExempt,
    StartGuildAction, CloseGuildAction,
    BroadCast, Creator
}