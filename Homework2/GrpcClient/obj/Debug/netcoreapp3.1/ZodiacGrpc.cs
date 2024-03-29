// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Zodiac
  {
    static readonly string __ServiceName = "Zodiac";

    static readonly grpc::Marshaller<global::GrpcServer.DateRequest> __Marshaller_DateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.DateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.ZodiacResponse> __Marshaller_ZodiacResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.ZodiacResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.DateRequest, global::GrpcServer.ZodiacResponse> __Method_GetZodiacSign = new grpc::Method<global::GrpcServer.DateRequest, global::GrpcServer.ZodiacResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetZodiacSign",
        __Marshaller_DateRequest,
        __Marshaller_ZodiacResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.ZodiacReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Zodiac</summary>
    public partial class ZodiacClient : grpc::ClientBase<ZodiacClient>
    {
      /// <summary>Creates a new client for Zodiac</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZodiacClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Zodiac that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZodiacClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZodiacClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZodiacClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.ZodiacResponse GetZodiacSign(global::GrpcServer.DateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetZodiacSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.ZodiacResponse GetZodiacSign(global::GrpcServer.DateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetZodiacSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.ZodiacResponse> GetZodiacSignAsync(global::GrpcServer.DateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetZodiacSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.ZodiacResponse> GetZodiacSignAsync(global::GrpcServer.DateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetZodiacSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZodiacClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZodiacClient(configuration);
      }
    }

  }
}
#endregion
