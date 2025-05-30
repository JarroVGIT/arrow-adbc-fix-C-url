/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.21.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


// targeting netstandard 2.x
#if(! NETSTANDARD2_0_OR_GREATER && ! NET6_0_OR_GREATER && ! NET472_OR_GREATER)
#error Unexpected target platform. See 'thrift --help' for details.
#endif

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable CS0618   // silence our own deprecation warnings
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Apache.Hive.Service.Rpc.Thrift
{

  internal partial class TDownloadDataResp : TBase
  {

    public global::Apache.Hive.Service.Rpc.Thrift.TStatus Status { get; set; }

    public global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle OperationHandle { get; set; }

    public TDownloadDataResp()
    {
    }

    public TDownloadDataResp(global::Apache.Hive.Service.Rpc.Thrift.TStatus @status, global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle operationHandle) : this()
    {
      this.Status = @status;
      this.OperationHandle = operationHandle;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_status = false;
        bool isset_operationHandle = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct)
              {
                Status = new global::Apache.Hive.Service.Rpc.Thrift.TStatus();
                await Status.ReadAsync(iprot, cancellationToken);
                isset_status = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                OperationHandle = new global::Apache.Hive.Service.Rpc.Thrift.TOperationHandle();
                await OperationHandle.ReadAsync(iprot, cancellationToken);
                isset_operationHandle = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default:
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_status)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_operationHandle)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp480 = new TStruct("TDownloadDataResp");
        await oprot.WriteStructBeginAsync(tmp480, cancellationToken);
        var tmp481 = new TField();
        if((Status != null))
        {
          tmp481.Name = "status";
          tmp481.Type = TType.Struct;
          tmp481.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp481, cancellationToken);
          await Status.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((OperationHandle != null))
        {
          tmp481.Name = "operationHandle";
          tmp481.Type = TType.Struct;
          tmp481.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp481, cancellationToken);
          await OperationHandle.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is TDownloadDataResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(Status, other.Status)
        && global::System.Object.Equals(OperationHandle, other.OperationHandle);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Status != null))
        {
          hashcode = (hashcode * 397) + Status.GetHashCode();
        }
        if((OperationHandle != null))
        {
          hashcode = (hashcode * 397) + OperationHandle.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp482 = new StringBuilder("TDownloadDataResp(");
      if((Status != null))
      {
        tmp482.Append(", Status: ");
        Status.ToString(tmp482);
      }
      if((OperationHandle != null))
      {
        tmp482.Append(", OperationHandle: ");
        OperationHandle.ToString(tmp482);
      }
      tmp482.Append(')');
      return tmp482.ToString();
    }
  }

}
