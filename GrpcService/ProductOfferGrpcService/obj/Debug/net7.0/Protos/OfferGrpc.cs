// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/offer.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProductOfferGrpcService.Protos {
  public static partial class ProductOfferService
  {
    static readonly string __ServiceName = "ProductOfferService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.Empty> __Marshaller_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.Offers> __Marshaller_Offers = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.Offers.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.GetOfferDetailRequest> __Marshaller_GetOfferDetailRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.GetOfferDetailRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.OfferDetail> __Marshaller_OfferDetail = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.OfferDetail.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.CreateOfferDetailRequest> __Marshaller_CreateOfferDetailRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.CreateOfferDetailRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.UpdateOfferDetailRequest> __Marshaller_UpdateOfferDetailRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.UpdateOfferDetailRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.DeleteOfferDetailRequest> __Marshaller_DeleteOfferDetailRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.DeleteOfferDetailRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductOfferGrpcService.Protos.DeleteOfferDetailResponse> __Marshaller_DeleteOfferDetailResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductOfferGrpcService.Protos.DeleteOfferDetailResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductOfferGrpcService.Protos.Empty, global::ProductOfferGrpcService.Protos.Offers> __Method_GetOfferList = new grpc::Method<global::ProductOfferGrpcService.Protos.Empty, global::ProductOfferGrpcService.Protos.Offers>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOfferList",
        __Marshaller_Empty,
        __Marshaller_Offers);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductOfferGrpcService.Protos.GetOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail> __Method_GetOffer = new grpc::Method<global::ProductOfferGrpcService.Protos.GetOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOffer",
        __Marshaller_GetOfferDetailRequest,
        __Marshaller_OfferDetail);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductOfferGrpcService.Protos.CreateOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail> __Method_CreateOffer = new grpc::Method<global::ProductOfferGrpcService.Protos.CreateOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateOffer",
        __Marshaller_CreateOfferDetailRequest,
        __Marshaller_OfferDetail);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductOfferGrpcService.Protos.UpdateOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail> __Method_UpdateOffer = new grpc::Method<global::ProductOfferGrpcService.Protos.UpdateOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateOffer",
        __Marshaller_UpdateOfferDetailRequest,
        __Marshaller_OfferDetail);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductOfferGrpcService.Protos.DeleteOfferDetailRequest, global::ProductOfferGrpcService.Protos.DeleteOfferDetailResponse> __Method_DeleteOffer = new grpc::Method<global::ProductOfferGrpcService.Protos.DeleteOfferDetailRequest, global::ProductOfferGrpcService.Protos.DeleteOfferDetailResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteOffer",
        __Marshaller_DeleteOfferDetailRequest,
        __Marshaller_DeleteOfferDetailResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProductOfferGrpcService.Protos.OfferReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductOfferService</summary>
    [grpc::BindServiceMethod(typeof(ProductOfferService), "BindService")]
    public abstract partial class ProductOfferServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductOfferGrpcService.Protos.Offers> GetOfferList(global::ProductOfferGrpcService.Protos.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductOfferGrpcService.Protos.OfferDetail> GetOffer(global::ProductOfferGrpcService.Protos.GetOfferDetailRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductOfferGrpcService.Protos.OfferDetail> CreateOffer(global::ProductOfferGrpcService.Protos.CreateOfferDetailRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductOfferGrpcService.Protos.OfferDetail> UpdateOffer(global::ProductOfferGrpcService.Protos.UpdateOfferDetailRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductOfferGrpcService.Protos.DeleteOfferDetailResponse> DeleteOffer(global::ProductOfferGrpcService.Protos.DeleteOfferDetailRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductOfferServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetOfferList, serviceImpl.GetOfferList)
          .AddMethod(__Method_GetOffer, serviceImpl.GetOffer)
          .AddMethod(__Method_CreateOffer, serviceImpl.CreateOffer)
          .AddMethod(__Method_UpdateOffer, serviceImpl.UpdateOffer)
          .AddMethod(__Method_DeleteOffer, serviceImpl.DeleteOffer).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductOfferServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetOfferList, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductOfferGrpcService.Protos.Empty, global::ProductOfferGrpcService.Protos.Offers>(serviceImpl.GetOfferList));
      serviceBinder.AddMethod(__Method_GetOffer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductOfferGrpcService.Protos.GetOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail>(serviceImpl.GetOffer));
      serviceBinder.AddMethod(__Method_CreateOffer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductOfferGrpcService.Protos.CreateOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail>(serviceImpl.CreateOffer));
      serviceBinder.AddMethod(__Method_UpdateOffer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductOfferGrpcService.Protos.UpdateOfferDetailRequest, global::ProductOfferGrpcService.Protos.OfferDetail>(serviceImpl.UpdateOffer));
      serviceBinder.AddMethod(__Method_DeleteOffer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductOfferGrpcService.Protos.DeleteOfferDetailRequest, global::ProductOfferGrpcService.Protos.DeleteOfferDetailResponse>(serviceImpl.DeleteOffer));
    }

  }
}
#endregion
