﻿//  SOLUTION  ： 农业气象物联网V3
//  PROJECT     ： Ahnqiot.Web.Api
//  FILENAME   ： ExceptionCode.cs
//  AUTHOR     ： soft-cq
//  CREATE TIME： 2016-04-14 15:09
//  COPYRIGHT  ： 版权所有 (C) 物联网科技有限公司 http://www.smartah.cc/ 2011~2016

using System.ComponentModel;
using System.Runtime.Serialization;

namespace Ahnqiot.Web.Api.Providers.Results
{
    /// <summary>
    /// 错误类型
    /// </summary>
    public enum ExceptionCode
    {
        [Description("正常")] [EnumMember(Value = "正常")] Success,
        [Description("不支持的数据格式")] [EnumMember(Value = "不支持的数据格式")] NotSupportedFormat,
        [Description("无权限")] [EnumMember(Value = "无权限")] AuthorizeFailed,
        [Description("内部错误")] [EnumMember(Value = "内部错误")] InternalError,
        [Description("无数据内容")] [EnumMember(Value = "无数据内容")] NoContent,
        [Description("基地不存在")] [EnumMember(Value = "基地不存在")] FarmNotExists,
        [Description("设施类型不存在")] [EnumMember(Value = "设施类型不存在")] FacilityTypeNotExists,
        [Description("设施不存在")] [EnumMember(Value = "设施不存在")] FacilityNotExists,
        [Description("设备类型不存在")] [EnumMember(Value = "设备类型不存在")] DeviceTypeNotExists,
        [Description("设备不存在")] [EnumMember(Value = "设备不存在")] DeviceNotExists,
        [Description("无法处理请求的数据")] [EnumMember(Value = "无法处理请求的数据")] CanNotProcessRequestData
    }
}