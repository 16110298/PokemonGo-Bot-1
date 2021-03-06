// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Map/Weather/DisplayWeather.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map.Weather {

  /// <summary>Holder for reflection information generated from POGOProtos/Map/Weather/DisplayWeather.proto</summary>
  public static partial class DisplayWeatherReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Map/Weather/DisplayWeather.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayWeatherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL01hcC9XZWF0aGVyL0Rpc3BsYXlXZWF0aGVyLnByb3Rv",
            "EhZQT0dPUHJvdG9zLk1hcC5XZWF0aGVyItkDCg5EaXNwbGF5V2VhdGhlchJI",
            "CgtjbG91ZF9sZXZlbBgBIAEoDjIzLlBPR09Qcm90b3MuTWFwLldlYXRoZXIu",
            "RGlzcGxheVdlYXRoZXIuRGlzcGxheUxldmVsEkcKCnJhaW5fbGV2ZWwYAiAB",
            "KA4yMy5QT0dPUHJvdG9zLk1hcC5XZWF0aGVyLkRpc3BsYXlXZWF0aGVyLkRp",
            "c3BsYXlMZXZlbBJHCgp3aW5kX2xldmVsGAMgASgOMjMuUE9HT1Byb3Rvcy5N",
            "YXAuV2VhdGhlci5EaXNwbGF5V2VhdGhlci5EaXNwbGF5TGV2ZWwSRwoKc25v",
            "d19sZXZlbBgEIAEoDjIzLlBPR09Qcm90b3MuTWFwLldlYXRoZXIuRGlzcGxh",
            "eVdlYXRoZXIuRGlzcGxheUxldmVsEkYKCWZvZ19sZXZlbBgFIAEoDjIzLlBP",
            "R09Qcm90b3MuTWFwLldlYXRoZXIuRGlzcGxheVdlYXRoZXIuRGlzcGxheUxl",
            "dmVsEhYKDndpbmRfZGlyZWN0aW9uGAYgASgFIkIKDERpc3BsYXlMZXZlbBIL",
            "CgdMRVZFTF8wEAASCwoHTEVWRUxfMRABEgsKB0xFVkVMXzIQAhILCgdMRVZF",
            "TF8zEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Map.Weather.DisplayWeather), global::POGOProtos.Map.Weather.DisplayWeather.Parser, new[]{ "CloudLevel", "RainLevel", "WindLevel", "SnowLevel", "FogLevel", "WindDirection" }, null, new[]{ typeof(global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DisplayWeather : pb::IMessage<DisplayWeather> {
    private static readonly pb::MessageParser<DisplayWeather> _parser = new pb::MessageParser<DisplayWeather>(() => new DisplayWeather());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DisplayWeather> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Map.Weather.DisplayWeatherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayWeather() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayWeather(DisplayWeather other) : this() {
      cloudLevel_ = other.cloudLevel_;
      rainLevel_ = other.rainLevel_;
      windLevel_ = other.windLevel_;
      snowLevel_ = other.snowLevel_;
      fogLevel_ = other.fogLevel_;
      windDirection_ = other.windDirection_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayWeather Clone() {
      return new DisplayWeather(this);
    }

    /// <summary>Field number for the "cloud_level" field.</summary>
    public const int CloudLevelFieldNumber = 1;
    private global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel cloudLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel CloudLevel {
      get { return cloudLevel_; }
      set {
        cloudLevel_ = value;
      }
    }

    /// <summary>Field number for the "rain_level" field.</summary>
    public const int RainLevelFieldNumber = 2;
    private global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel rainLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel RainLevel {
      get { return rainLevel_; }
      set {
        rainLevel_ = value;
      }
    }

    /// <summary>Field number for the "wind_level" field.</summary>
    public const int WindLevelFieldNumber = 3;
    private global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel windLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel WindLevel {
      get { return windLevel_; }
      set {
        windLevel_ = value;
      }
    }

    /// <summary>Field number for the "snow_level" field.</summary>
    public const int SnowLevelFieldNumber = 4;
    private global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel snowLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel SnowLevel {
      get { return snowLevel_; }
      set {
        snowLevel_ = value;
      }
    }

    /// <summary>Field number for the "fog_level" field.</summary>
    public const int FogLevelFieldNumber = 5;
    private global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel fogLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel FogLevel {
      get { return fogLevel_; }
      set {
        fogLevel_ = value;
      }
    }

    /// <summary>Field number for the "wind_direction" field.</summary>
    public const int WindDirectionFieldNumber = 6;
    private int windDirection_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int WindDirection {
      get { return windDirection_; }
      set {
        windDirection_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DisplayWeather);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DisplayWeather other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CloudLevel != other.CloudLevel) return false;
      if (RainLevel != other.RainLevel) return false;
      if (WindLevel != other.WindLevel) return false;
      if (SnowLevel != other.SnowLevel) return false;
      if (FogLevel != other.FogLevel) return false;
      if (WindDirection != other.WindDirection) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CloudLevel != 0) hash ^= CloudLevel.GetHashCode();
      if (RainLevel != 0) hash ^= RainLevel.GetHashCode();
      if (WindLevel != 0) hash ^= WindLevel.GetHashCode();
      if (SnowLevel != 0) hash ^= SnowLevel.GetHashCode();
      if (FogLevel != 0) hash ^= FogLevel.GetHashCode();
      if (WindDirection != 0) hash ^= WindDirection.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CloudLevel != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) CloudLevel);
      }
      if (RainLevel != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) RainLevel);
      }
      if (WindLevel != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) WindLevel);
      }
      if (SnowLevel != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) SnowLevel);
      }
      if (FogLevel != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) FogLevel);
      }
      if (WindDirection != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(WindDirection);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CloudLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CloudLevel);
      }
      if (RainLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RainLevel);
      }
      if (WindLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) WindLevel);
      }
      if (SnowLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SnowLevel);
      }
      if (FogLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FogLevel);
      }
      if (WindDirection != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(WindDirection);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DisplayWeather other) {
      if (other == null) {
        return;
      }
      if (other.CloudLevel != 0) {
        CloudLevel = other.CloudLevel;
      }
      if (other.RainLevel != 0) {
        RainLevel = other.RainLevel;
      }
      if (other.WindLevel != 0) {
        WindLevel = other.WindLevel;
      }
      if (other.SnowLevel != 0) {
        SnowLevel = other.SnowLevel;
      }
      if (other.FogLevel != 0) {
        FogLevel = other.FogLevel;
      }
      if (other.WindDirection != 0) {
        WindDirection = other.WindDirection;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            cloudLevel_ = (global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 16: {
            rainLevel_ = (global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 24: {
            windLevel_ = (global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 32: {
            snowLevel_ = (global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 40: {
            fogLevel_ = (global::POGOProtos.Map.Weather.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 48: {
            WindDirection = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DisplayWeather message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum DisplayLevel {
        [pbr::OriginalName("LEVEL_0")] Level0 = 0,
        [pbr::OriginalName("LEVEL_1")] Level1 = 1,
        [pbr::OriginalName("LEVEL_2")] Level2 = 2,
        [pbr::OriginalName("LEVEL_3")] Level3 = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
