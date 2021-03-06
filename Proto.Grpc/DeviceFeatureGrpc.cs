// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: device_feature.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcDeviceFeature {
  public static partial class DeviceFeature
  {
    static readonly string __ServiceName = "GrpcDeviceFeature.DeviceFeature";

    static readonly grpc::Marshaller<global::GrpcDeviceFeature.DeviceStateQueryRequest> __Marshaller_DeviceStateQueryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDeviceFeature.DeviceStateQueryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDeviceFeature.DeviceStateQueryReply> __Marshaller_DeviceStateQueryReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDeviceFeature.DeviceStateQueryReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcDeviceFeature.DeviceStateQueryRequest, global::GrpcDeviceFeature.DeviceStateQueryReply> __Method_DeviceStateQuery = new grpc::Method<global::GrpcDeviceFeature.DeviceStateQueryRequest, global::GrpcDeviceFeature.DeviceStateQueryReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeviceStateQuery",
        __Marshaller_DeviceStateQueryRequest,
        __Marshaller_DeviceStateQueryReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcDeviceFeature.DeviceFeatureReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DeviceFeature</summary>
    public abstract partial class DeviceFeatureBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcDeviceFeature.DeviceStateQueryReply> DeviceStateQuery(global::GrpcDeviceFeature.DeviceStateQueryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DeviceFeature</summary>
    public partial class DeviceFeatureClient : grpc::ClientBase<DeviceFeatureClient>
    {
      /// <summary>Creates a new client for DeviceFeature</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DeviceFeatureClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DeviceFeature that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DeviceFeatureClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DeviceFeatureClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DeviceFeatureClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcDeviceFeature.DeviceStateQueryReply DeviceStateQuery(global::GrpcDeviceFeature.DeviceStateQueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeviceStateQuery(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcDeviceFeature.DeviceStateQueryReply DeviceStateQuery(global::GrpcDeviceFeature.DeviceStateQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeviceStateQuery, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDeviceFeature.DeviceStateQueryReply> DeviceStateQueryAsync(global::GrpcDeviceFeature.DeviceStateQueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeviceStateQueryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDeviceFeature.DeviceStateQueryReply> DeviceStateQueryAsync(global::GrpcDeviceFeature.DeviceStateQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeviceStateQuery, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DeviceFeatureClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DeviceFeatureClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DeviceFeatureBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeviceStateQuery, serviceImpl.DeviceStateQuery).Build();
    }

  }
}
#endregion
