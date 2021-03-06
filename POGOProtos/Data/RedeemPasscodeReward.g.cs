// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/RedeemPasscodeReward.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/RedeemPasscodeReward.proto</summary>
  public static partial class RedeemPasscodeRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/RedeemPasscodeReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedeemPasscodeRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipQT0dPUHJvdG9zL0RhdGEvUmVkZWVtUGFzc2NvZGVSZXdhcmQucHJvdG8S",
            "D1BPR09Qcm90b3MuRGF0YRogUE9HT1Byb3Rvcy9FbnVtcy9CYWRnZVR5cGUu",
            "cHJvdG8aIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90bxomUE9H",
            "T1Byb3Rvcy9EYXRhL1JlZGVlbS9Qb2tlQ2FuZHkucHJvdG8aL1BPR09Qcm90",
            "b3MvRGF0YS9SZWRlZW0vUmVkZWVtZWRBdmF0YXJJdGVtLnByb3RvGilQT0dP",
            "UHJvdG9zL0RhdGEvUmVkZWVtL1JlZGVlbWVkSXRlbS5wcm90byL4AgoUUmVk",
            "ZWVtUGFzc2NvZGVSZXdhcmQSMwoFaXRlbXMYASADKAsyJC5QT0dPUHJvdG9z",
            "LkRhdGEuUmVkZWVtLlJlZGVlbWVkSXRlbRJACgxhdmF0YXJfaXRlbXMYAiAD",
            "KAsyKi5QT0dPUHJvdG9zLkRhdGEuUmVkZWVtLlJlZGVlbWVkQXZhdGFySXRl",
            "bRIxCgtlZ2dfcG9rZW1vbhgDIAMoCzIcLlBPR09Qcm90b3MuRGF0YS5Qb2tl",
            "bW9uRGF0YRItCgdwb2tlbW9uGAQgAygLMhwuUE9HT1Byb3Rvcy5EYXRhLlBv",
            "a2Vtb25EYXRhEjUKCnBva2VfY2FuZHkYBSADKAsyIS5QT0dPUHJvdG9zLkRh",
            "dGEuUmVkZWVtLlBva2VDYW5keRIQCghzdGFyZHVzdBgGIAEoBRIRCglwb2tl",
            "Y29pbnMYByABKAUSKwoGYmFkZ2VzGAggAygOMhsuUE9HT1Byb3Rvcy5FbnVt",
            "cy5CYWRnZVR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Data.Redeem.PokeCandyReflection.Descriptor, global::POGOProtos.Data.Redeem.RedeemedAvatarItemReflection.Descriptor, global::POGOProtos.Data.Redeem.RedeemedItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.RedeemPasscodeReward), global::POGOProtos.Data.RedeemPasscodeReward.Parser, new[]{ "Items", "AvatarItems", "EggPokemon", "Pokemon", "PokeCandy", "Stardust", "Pokecoins", "Badges" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RedeemPasscodeReward : pb::IMessage<RedeemPasscodeReward> {
    private static readonly pb::MessageParser<RedeemPasscodeReward> _parser = new pb::MessageParser<RedeemPasscodeReward>(() => new RedeemPasscodeReward());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemPasscodeReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.RedeemPasscodeRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeReward(RedeemPasscodeReward other) : this() {
      items_ = other.items_.Clone();
      avatarItems_ = other.avatarItems_.Clone();
      eggPokemon_ = other.eggPokemon_.Clone();
      pokemon_ = other.pokemon_.Clone();
      pokeCandy_ = other.pokeCandy_.Clone();
      stardust_ = other.stardust_;
      pokecoins_ = other.pokecoins_;
      badges_ = other.badges_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeReward Clone() {
      return new RedeemPasscodeReward(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Redeem.RedeemedItem> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Data.Redeem.RedeemedItem.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Redeem.RedeemedItem> items_ = new pbc::RepeatedField<global::POGOProtos.Data.Redeem.RedeemedItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Redeem.RedeemedItem> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "avatar_items" field.</summary>
    public const int AvatarItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Redeem.RedeemedAvatarItem> _repeated_avatarItems_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Redeem.RedeemedAvatarItem.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Redeem.RedeemedAvatarItem> avatarItems_ = new pbc::RepeatedField<global::POGOProtos.Data.Redeem.RedeemedAvatarItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Redeem.RedeemedAvatarItem> AvatarItems {
      get { return avatarItems_; }
    }

    /// <summary>Field number for the "egg_pokemon" field.</summary>
    public const int EggPokemonFieldNumber = 3;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.PokemonData> _repeated_eggPokemon_codec
        = pb::FieldCodec.ForMessage(26, global::POGOProtos.Data.PokemonData.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.PokemonData> eggPokemon_ = new pbc::RepeatedField<global::POGOProtos.Data.PokemonData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.PokemonData> EggPokemon {
      get { return eggPokemon_; }
    }

    /// <summary>Field number for the "pokemon" field.</summary>
    public const int PokemonFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.PokemonData> _repeated_pokemon_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Data.PokemonData.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.PokemonData> pokemon_ = new pbc::RepeatedField<global::POGOProtos.Data.PokemonData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.PokemonData> Pokemon {
      get { return pokemon_; }
    }

    /// <summary>Field number for the "poke_candy" field.</summary>
    public const int PokeCandyFieldNumber = 5;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Redeem.PokeCandy> _repeated_pokeCandy_codec
        = pb::FieldCodec.ForMessage(42, global::POGOProtos.Data.Redeem.PokeCandy.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Redeem.PokeCandy> pokeCandy_ = new pbc::RepeatedField<global::POGOProtos.Data.Redeem.PokeCandy>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Redeem.PokeCandy> PokeCandy {
      get { return pokeCandy_; }
    }

    /// <summary>Field number for the "stardust" field.</summary>
    public const int StardustFieldNumber = 6;
    private int stardust_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stardust {
      get { return stardust_; }
      set {
        stardust_ = value;
      }
    }

    /// <summary>Field number for the "pokecoins" field.</summary>
    public const int PokecoinsFieldNumber = 7;
    private int pokecoins_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Pokecoins {
      get { return pokecoins_; }
      set {
        pokecoins_ = value;
      }
    }

    /// <summary>Field number for the "badges" field.</summary>
    public const int BadgesFieldNumber = 8;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.BadgeType> _repeated_badges_codec
        = pb::FieldCodec.ForEnum(66, x => (int) x, x => (global::POGOProtos.Enums.BadgeType) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.BadgeType> badges_ = new pbc::RepeatedField<global::POGOProtos.Enums.BadgeType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.BadgeType> Badges {
      get { return badges_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemPasscodeReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemPasscodeReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!items_.Equals(other.items_)) return false;
      if(!avatarItems_.Equals(other.avatarItems_)) return false;
      if(!eggPokemon_.Equals(other.eggPokemon_)) return false;
      if(!pokemon_.Equals(other.pokemon_)) return false;
      if(!pokeCandy_.Equals(other.pokeCandy_)) return false;
      if (Stardust != other.Stardust) return false;
      if (Pokecoins != other.Pokecoins) return false;
      if(!badges_.Equals(other.badges_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= items_.GetHashCode();
      hash ^= avatarItems_.GetHashCode();
      hash ^= eggPokemon_.GetHashCode();
      hash ^= pokemon_.GetHashCode();
      hash ^= pokeCandy_.GetHashCode();
      if (Stardust != 0) hash ^= Stardust.GetHashCode();
      if (Pokecoins != 0) hash ^= Pokecoins.GetHashCode();
      hash ^= badges_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      items_.WriteTo(output, _repeated_items_codec);
      avatarItems_.WriteTo(output, _repeated_avatarItems_codec);
      eggPokemon_.WriteTo(output, _repeated_eggPokemon_codec);
      pokemon_.WriteTo(output, _repeated_pokemon_codec);
      pokeCandy_.WriteTo(output, _repeated_pokeCandy_codec);
      if (Stardust != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Stardust);
      }
      if (Pokecoins != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Pokecoins);
      }
      badges_.WriteTo(output, _repeated_badges_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_repeated_items_codec);
      size += avatarItems_.CalculateSize(_repeated_avatarItems_codec);
      size += eggPokemon_.CalculateSize(_repeated_eggPokemon_codec);
      size += pokemon_.CalculateSize(_repeated_pokemon_codec);
      size += pokeCandy_.CalculateSize(_repeated_pokeCandy_codec);
      if (Stardust != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stardust);
      }
      if (Pokecoins != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Pokecoins);
      }
      size += badges_.CalculateSize(_repeated_badges_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemPasscodeReward other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
      avatarItems_.Add(other.avatarItems_);
      eggPokemon_.Add(other.eggPokemon_);
      pokemon_.Add(other.pokemon_);
      pokeCandy_.Add(other.pokeCandy_);
      if (other.Stardust != 0) {
        Stardust = other.Stardust;
      }
      if (other.Pokecoins != 0) {
        Pokecoins = other.Pokecoins;
      }
      badges_.Add(other.badges_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 18: {
            avatarItems_.AddEntriesFrom(input, _repeated_avatarItems_codec);
            break;
          }
          case 26: {
            eggPokemon_.AddEntriesFrom(input, _repeated_eggPokemon_codec);
            break;
          }
          case 34: {
            pokemon_.AddEntriesFrom(input, _repeated_pokemon_codec);
            break;
          }
          case 42: {
            pokeCandy_.AddEntriesFrom(input, _repeated_pokeCandy_codec);
            break;
          }
          case 48: {
            Stardust = input.ReadInt32();
            break;
          }
          case 56: {
            Pokecoins = input.ReadInt32();
            break;
          }
          case 66:
          case 64: {
            badges_.AddEntriesFrom(input, _repeated_badges_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
