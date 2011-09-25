// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.toon {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class Toon {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_toon_ToonHandle__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.toon.ToonHandle, global::bnet.protocol.toon.ToonHandle.Builder> internal__static_bnet_protocol_toon_ToonHandle__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_toon_ToonName__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.toon.ToonName, global::bnet.protocol.toon.ToonName.Builder> internal__static_bnet_protocol_toon_ToonName__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_toon_ToonInfo__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.toon.ToonInfo, global::bnet.protocol.toon.ToonInfo.Builder> internal__static_bnet_protocol_toon_ToonInfo__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Toon() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChdzZXJ2aWNlL3Rvb24vdG9vbi5wcm90bxISYm5ldC5wcm90b2NvbC50b29u" + 
          "IkgKClRvb25IYW5kbGUSCgoCaWQYASACKAYSDwoHcHJvZ3JhbRgCIAIoBxIO" + 
          "CgZyZWdpb24YAyACKA0SDQoFcmVhbG0YBCACKA0iHQoIVG9vbk5hbWUSEQoJ" + 
          "ZnVsbF9uYW1lGAEgAigJIjYKCFRvb25JbmZvEioKBG5hbWUYASACKAsyHC5i" + 
          "bmV0LnByb3RvY29sLnRvb24uVG9vbk5hbWVCA4ABAA==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_toon_ToonHandle__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_toon_ToonHandle__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.toon.ToonHandle, global::bnet.protocol.toon.ToonHandle.Builder>(internal__static_bnet_protocol_toon_ToonHandle__Descriptor,
                new string[] { "Id", "Program", "Region", "Realm", });
        internal__static_bnet_protocol_toon_ToonName__Descriptor = Descriptor.MessageTypes[1];
        internal__static_bnet_protocol_toon_ToonName__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.toon.ToonName, global::bnet.protocol.toon.ToonName.Builder>(internal__static_bnet_protocol_toon_ToonName__Descriptor,
                new string[] { "FullName", });
        internal__static_bnet_protocol_toon_ToonInfo__Descriptor = Descriptor.MessageTypes[2];
        internal__static_bnet_protocol_toon_ToonInfo__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.toon.ToonInfo, global::bnet.protocol.toon.ToonInfo.Builder>(internal__static_bnet_protocol_toon_ToonInfo__Descriptor,
                new string[] { "Name", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class ToonHandle : pb::GeneratedMessage<ToonHandle, ToonHandle.Builder> {
    private static readonly ToonHandle defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _toonHandleFieldNames = new string[] { "id", "program", "realm", "region" };
    private static readonly uint[] _toonHandleFieldTags = new uint[] { 9, 21, 32, 24 };
    public static ToonHandle DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ToonHandle DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override ToonHandle ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.toon.Toon.internal__static_bnet_protocol_toon_ToonHandle__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<ToonHandle, ToonHandle.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.toon.Toon.internal__static_bnet_protocol_toon_ToonHandle__FieldAccessorTable; }
    }
    
    public const int IdFieldNumber = 1;
    private bool hasId;
    private ulong id_;
    public bool HasId {
      get { return hasId; }
    }
    public ulong Id {
      get { return id_; }
    }
    
    public const int ProgramFieldNumber = 2;
    private bool hasProgram;
    private uint program_;
    public bool HasProgram {
      get { return hasProgram; }
    }
    public uint Program {
      get { return program_; }
    }
    
    public const int RegionFieldNumber = 3;
    private bool hasRegion;
    private uint region_;
    public bool HasRegion {
      get { return hasRegion; }
    }
    public uint Region {
      get { return region_; }
    }
    
    public const int RealmFieldNumber = 4;
    private bool hasRealm;
    private uint realm_;
    public bool HasRealm {
      get { return hasRealm; }
    }
    public uint Realm {
      get { return realm_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasId) return false;
        if (!hasProgram) return false;
        if (!hasRegion) return false;
        if (!hasRealm) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _toonHandleFieldNames;
      if (hasId) {
        output.WriteFixed64(1, field_names[0], Id);
      }
      if (hasProgram) {
        output.WriteFixed32(2, field_names[1], Program);
      }
      if (hasRegion) {
        output.WriteUInt32(3, field_names[3], Region);
      }
      if (hasRealm) {
        output.WriteUInt32(4, field_names[2], Realm);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasId) {
          size += pb::CodedOutputStream.ComputeFixed64Size(1, Id);
        }
        if (hasProgram) {
          size += pb::CodedOutputStream.ComputeFixed32Size(2, Program);
        }
        if (hasRegion) {
          size += pb::CodedOutputStream.ComputeUInt32Size(3, Region);
        }
        if (hasRealm) {
          size += pb::CodedOutputStream.ComputeUInt32Size(4, Realm);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static ToonHandle ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonHandle ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonHandle ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonHandle ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonHandle ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonHandle ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ToonHandle ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ToonHandle ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ToonHandle ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonHandle ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ToonHandle prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<ToonHandle, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      ToonHandle result = new ToonHandle();
      
      protected override ToonHandle MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new ToonHandle();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.toon.ToonHandle.Descriptor; }
      }
      
      public override ToonHandle DefaultInstanceForType {
        get { return global::bnet.protocol.toon.ToonHandle.DefaultInstance; }
      }
      
      public override ToonHandle BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        ToonHandle returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is ToonHandle) {
          return MergeFrom((ToonHandle) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ToonHandle other) {
        if (other == global::bnet.protocol.toon.ToonHandle.DefaultInstance) return this;
        if (other.HasId) {
          Id = other.Id;
        }
        if (other.HasProgram) {
          Program = other.Program;
        }
        if (other.HasRegion) {
          Region = other.Region;
        }
        if (other.HasRealm) {
          Realm = other.Realm;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_toonHandleFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _toonHandleFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 9: {
              result.hasId = input.ReadFixed64(ref result.id_);
              break;
            }
            case 21: {
              result.hasProgram = input.ReadFixed32(ref result.program_);
              break;
            }
            case 24: {
              result.hasRegion = input.ReadUInt32(ref result.region_);
              break;
            }
            case 32: {
              result.hasRealm = input.ReadUInt32(ref result.realm_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasId {
        get { return result.hasId; }
      }
      public ulong Id {
        get { return result.Id; }
        set { SetId(value); }
      }
      public Builder SetId(ulong value) {
        result.hasId = true;
        result.id_ = value;
        return this;
      }
      public Builder ClearId() {
        result.hasId = false;
        result.id_ = 0;
        return this;
      }
      
      public bool HasProgram {
        get { return result.hasProgram; }
      }
      public uint Program {
        get { return result.Program; }
        set { SetProgram(value); }
      }
      public Builder SetProgram(uint value) {
        result.hasProgram = true;
        result.program_ = value;
        return this;
      }
      public Builder ClearProgram() {
        result.hasProgram = false;
        result.program_ = 0;
        return this;
      }
      
      public bool HasRegion {
        get { return result.hasRegion; }
      }
      public uint Region {
        get { return result.Region; }
        set { SetRegion(value); }
      }
      public Builder SetRegion(uint value) {
        result.hasRegion = true;
        result.region_ = value;
        return this;
      }
      public Builder ClearRegion() {
        result.hasRegion = false;
        result.region_ = 0;
        return this;
      }
      
      public bool HasRealm {
        get { return result.hasRealm; }
      }
      public uint Realm {
        get { return result.Realm; }
        set { SetRealm(value); }
      }
      public Builder SetRealm(uint value) {
        result.hasRealm = true;
        result.realm_ = value;
        return this;
      }
      public Builder ClearRealm() {
        result.hasRealm = false;
        result.realm_ = 0;
        return this;
      }
    }
    static ToonHandle() {
      object.ReferenceEquals(global::bnet.protocol.toon.Toon.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class ToonName : pb::GeneratedMessage<ToonName, ToonName.Builder> {
    private static readonly ToonName defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _toonNameFieldNames = new string[] { "full_name" };
    private static readonly uint[] _toonNameFieldTags = new uint[] { 10 };
    public static ToonName DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ToonName DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override ToonName ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.toon.Toon.internal__static_bnet_protocol_toon_ToonName__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<ToonName, ToonName.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.toon.Toon.internal__static_bnet_protocol_toon_ToonName__FieldAccessorTable; }
    }
    
    public const int FullNameFieldNumber = 1;
    private bool hasFullName;
    private string fullName_ = "";
    public bool HasFullName {
      get { return hasFullName; }
    }
    public string FullName {
      get { return fullName_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasFullName) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _toonNameFieldNames;
      if (hasFullName) {
        output.WriteString(1, field_names[0], FullName);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasFullName) {
          size += pb::CodedOutputStream.ComputeStringSize(1, FullName);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static ToonName ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonName ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonName ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonName ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonName ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonName ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ToonName ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ToonName ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ToonName ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonName ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ToonName prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<ToonName, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      ToonName result = new ToonName();
      
      protected override ToonName MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new ToonName();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.toon.ToonName.Descriptor; }
      }
      
      public override ToonName DefaultInstanceForType {
        get { return global::bnet.protocol.toon.ToonName.DefaultInstance; }
      }
      
      public override ToonName BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        ToonName returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is ToonName) {
          return MergeFrom((ToonName) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ToonName other) {
        if (other == global::bnet.protocol.toon.ToonName.DefaultInstance) return this;
        if (other.HasFullName) {
          FullName = other.FullName;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_toonNameFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _toonNameFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasFullName = input.ReadString(ref result.fullName_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasFullName {
        get { return result.hasFullName; }
      }
      public string FullName {
        get { return result.FullName; }
        set { SetFullName(value); }
      }
      public Builder SetFullName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasFullName = true;
        result.fullName_ = value;
        return this;
      }
      public Builder ClearFullName() {
        result.hasFullName = false;
        result.fullName_ = "";
        return this;
      }
    }
    static ToonName() {
      object.ReferenceEquals(global::bnet.protocol.toon.Toon.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class ToonInfo : pb::GeneratedMessage<ToonInfo, ToonInfo.Builder> {
    private static readonly ToonInfo defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _toonInfoFieldNames = new string[] { "name" };
    private static readonly uint[] _toonInfoFieldTags = new uint[] { 10 };
    public static ToonInfo DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ToonInfo DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override ToonInfo ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.toon.Toon.internal__static_bnet_protocol_toon_ToonInfo__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<ToonInfo, ToonInfo.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.toon.Toon.internal__static_bnet_protocol_toon_ToonInfo__FieldAccessorTable; }
    }
    
    public const int NameFieldNumber = 1;
    private bool hasName;
    private global::bnet.protocol.toon.ToonName name_ = global::bnet.protocol.toon.ToonName.DefaultInstance;
    public bool HasName {
      get { return hasName; }
    }
    public global::bnet.protocol.toon.ToonName Name {
      get { return name_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasName) return false;
        if (!Name.IsInitialized) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _toonInfoFieldNames;
      if (hasName) {
        output.WriteMessage(1, field_names[0], Name);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasName) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Name);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static ToonInfo ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonInfo ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonInfo ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ToonInfo ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ToonInfo ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonInfo ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ToonInfo ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ToonInfo ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ToonInfo ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ToonInfo ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ToonInfo prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<ToonInfo, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      ToonInfo result = new ToonInfo();
      
      protected override ToonInfo MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new ToonInfo();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.toon.ToonInfo.Descriptor; }
      }
      
      public override ToonInfo DefaultInstanceForType {
        get { return global::bnet.protocol.toon.ToonInfo.DefaultInstance; }
      }
      
      public override ToonInfo BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        ToonInfo returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is ToonInfo) {
          return MergeFrom((ToonInfo) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ToonInfo other) {
        if (other == global::bnet.protocol.toon.ToonInfo.DefaultInstance) return this;
        if (other.HasName) {
          MergeName(other.Name);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_toonInfoFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _toonInfoFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::bnet.protocol.toon.ToonName.Builder subBuilder = global::bnet.protocol.toon.ToonName.CreateBuilder();
              if (result.hasName) {
                subBuilder.MergeFrom(Name);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Name = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasName {
       get { return result.hasName; }
      }
      public global::bnet.protocol.toon.ToonName Name {
        get { return result.Name; }
        set { SetName(value); }
      }
      public Builder SetName(global::bnet.protocol.toon.ToonName value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasName = true;
        result.name_ = value;
        return this;
      }
      public Builder SetName(global::bnet.protocol.toon.ToonName.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasName = true;
        result.name_ = builderForValue.Build();
        return this;
      }
      public Builder MergeName(global::bnet.protocol.toon.ToonName value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.hasName &&
            result.name_ != global::bnet.protocol.toon.ToonName.DefaultInstance) {
            result.name_ = global::bnet.protocol.toon.ToonName.CreateBuilder(result.name_).MergeFrom(value).BuildPartial();
        } else {
          result.name_ = value;
        }
        result.hasName = true;
        return this;
      }
      public Builder ClearName() {
        result.hasName = false;
        result.name_ = global::bnet.protocol.toon.ToonName.DefaultInstance;
        return this;
      }
    }
    static ToonInfo() {
      object.ReferenceEquals(global::bnet.protocol.toon.Toon.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
