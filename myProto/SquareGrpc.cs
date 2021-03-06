// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: square.proto
// </auto-generated>
// Original file comments:
// Copyright 2015 gRPC authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Square {
  public static partial class SquareService
  {
    static readonly string __ServiceName = "square.SquareService";

    static readonly grpc::Marshaller<global::Square.SquareRequest> __Marshaller_square_SquareRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Square.SquareRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Square.SquareReply> __Marshaller_square_SquareReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Square.SquareReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Square.SquareRequest, global::Square.SquareReply> __Method_RetSquare = new grpc::Method<global::Square.SquareRequest, global::Square.SquareReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RetSquare",
        __Marshaller_square_SquareRequest,
        __Marshaller_square_SquareReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Square.SquareReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SquareService</summary>
    public abstract partial class SquareServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Square.SquareReply> RetSquare(global::Square.SquareRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SquareService</summary>
    public partial class SquareServiceClient : grpc::ClientBase<SquareServiceClient>
    {
      /// <summary>Creates a new client for SquareService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SquareServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SquareService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SquareServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SquareServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SquareServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Square.SquareReply RetSquare(global::Square.SquareRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetSquare(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Square.SquareReply RetSquare(global::Square.SquareRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RetSquare, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Square.SquareReply> RetSquareAsync(global::Square.SquareRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetSquareAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Square.SquareReply> RetSquareAsync(global::Square.SquareRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RetSquare, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SquareServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SquareServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SquareServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RetSquare, serviceImpl.RetSquare).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SquareServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RetSquare, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Square.SquareRequest, global::Square.SquareReply>(serviceImpl.RetSquare));
    }

  }
}
#endregion
