// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/RedeemPasscodeMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/RedeemPasscodeMessage.proto</summary>
  public static partial class RedeemPasscodeMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/RedeemPasscodeMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedeemPasscodeMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvUmVk",
            "ZWVtUGFzc2NvZGVNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5ldHdvcmtp",
            "bmcuUmVxdWVzdHMuTWVzc2FnZXMiMAocUmVkZWVtUGFzc2NvZGVSZXF1ZXN0",
            "TWVzc2FnZRIQCghwYXNzY29kZRgBIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.RedeemPasscodeRequestMessage), global::POGOProtos.Networking.Requests.Messages.RedeemPasscodeRequestMessage.Parser, new[]{ "Passcode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RedeemPasscodeRequestMessage : pb::IMessage<RedeemPasscodeRequestMessage> {
    private static readonly pb::MessageParser<RedeemPasscodeRequestMessage> _parser = new pb::MessageParser<RedeemPasscodeRequestMessage>(() => new RedeemPasscodeRequestMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemPasscodeRequestMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.RedeemPasscodeMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeRequestMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeRequestMessage(RedeemPasscodeRequestMessage other) : this() {
      passcode_ = other.passcode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeRequestMessage Clone() {
      return new RedeemPasscodeRequestMessage(this);
    }

    /// <summary>Field number for the "passcode" field.</summary>
    public const int PasscodeFieldNumber = 1;
    private string passcode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Passcode {
      get { return passcode_; }
      set {
        passcode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemPasscodeRequestMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemPasscodeRequestMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Passcode != other.Passcode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Passcode.Length != 0) hash ^= Passcode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Passcode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Passcode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Passcode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Passcode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemPasscodeRequestMessage other) {
      if (other == null) {
        return;
      }
      if (other.Passcode.Length != 0) {
        Passcode = other.Passcode;
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
          case 10: {
            Passcode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code