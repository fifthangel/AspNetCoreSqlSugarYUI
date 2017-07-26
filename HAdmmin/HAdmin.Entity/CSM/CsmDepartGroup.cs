using System;
using System.Collections.Generic;
using System.Text;

namespace HAdmin.Entity.CSM
{

    /// <summary>
    /// 角色与平台（公司）对应关系
    /// </summary>
    //[Serializable]
    public class RolePlatMap
    {
        /// <summary>
        /// 角色Ids
        /// </summary>
        //[JsonProperty("roleIds")]
        public List<Role> RoleIds { get; set; }

        /// <summary>
        /// 平台Id
        /// </summary>
        //[JsonProperty("platId")]
        public int PlatId { get; set; }
    }

    //[Serializable]
    public class Role
    {
        //[JsonProperty("roleId")]
        public int RoleId { get; set; }
    }

    /// <summary>
    /// 公司--渠道--角色关系
    /// </summary>
    public class ChannelRoleMap
    {
        public int Id { get; set; }

        /// <summary>
        /// 公司Id（来源jx_erp_warehouse.WareSaleGroupType）1=酒仙,2=酒仙团,3=酒快到,7=中酿国际,9=酒神国际,10=联合供应链  
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        ///  公司对应角色Id(字符串,"|"分割)      
        /// </summary>
        public string CompanyRoleIds { get; set; }

        /// <summary>
        ///  公司对应角色Id list(int)
        /// </summary>
        public List<int> CompanyRoleIdList { get; set; }

        /// <summary>
        /// 公司下销售事业部分组Id，关联csm_depart_group (字符串,"|"分割)          
        /// </summary>
        public string DepartGroupId { get; set; }

        /// <summary>
        /// 公司下销售事业部分组Id,List(DepartGroup)
        /// </summary>
        public List<CsmDepartGroup> DepartGroupList { get; set; }

        /// <summary>
        /// 是否启用(0否，1是)
        /// </summary>
        public int Enable { get; set; }
    }

    /// <summary>
    /// 事业部分组
    /// </summary>
    public class CsmDepartGroup
    {
        public int Id { get; set; }

        /// <summary>
        /// 事业部分组名称  
        /// </summary>
        public string DepartGroupName { get; set; }

        /// <summary>
        /// 分组对就的角色（"|"分割）  
        /// </summary>
        public string GroupRoleIds { get; set; }

        /// <summary>
        /// 事部Id（"|"分割）  
        /// </summary>
        public string DeaprtIds { get; set; }

        /// <summary>
        /// 事部Id集合
        /// </summary>
        public List<int> DepartIdList { get; set; }

        /// <summary>
        /// 分组对就的角色集合
        /// </summary>
        public List<int> DepartRoles { get; set; }

        /// <summary>
        /// 屏蔽事业部下的渠道(字符串,"|"分割) 
        /// </summary>
        public string ScreenChannelIds { get; set; }

        /// <summary>
        /// 屏蔽事业部下的渠道,list(int)
        /// </summary>
        public List<int> ScreenChannelIdList { get; set; }

        /// <summary>
        /// 特殊角色与渠道对应（渠道n|角色n,渠道n+1|角色n+1....）
        /// </summary>
        public string SpeChannelRole { get; set; }

        /// <summary>
        /// 特殊角色与渠道集合，【channlId :roleId】
        /// </summary>
        public List<ChannelRole> SpeChannelRroleList { get; set; }

        /// <summary>
        /// 特殊角色与事业部对应（事业部n|角色n,事业部n+1|事业部n+1....）
        /// </summary>
        public string SpeDepartRole { get; set; }

        /// <summary>
        /// 特殊角色与事业部集合，【departId :roleId】
        /// </summary>
        public List<DivisionRole> SpeDivisionRoleList { get; set; }

        /// <summary>
        /// 分组下的渠道集合
        /// </summary>
        public List<ErpChannel> ErpChannelList { get; set; }

        /// <summary>
        /// 数据 状态
        /// </summary>
        public int Unable { get; set; }
    }

    /// <summary>
    /// 渠道-角色限定
    /// </summary>
    public class ChannelRole
    {
        /// <summary>
        /// 渠道Id
        /// </summary>
        public int ChannelId { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public int RoleId { get; set; }
    }

    /// <summary>
    /// 事业部-角色限定
    /// </summary>
    public class DivisionRole
    {
        /// <summary>
        /// 事业部Id
        /// </summary>
        public int DepartId { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public int RoleId { get; set; }
    }

    public class ErpChannel
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ErpChannel()
        {

        }
        /// <summary>
        /// 主键ID
        /// </summary>
        public Int16 channel_id { get; set; }
        /// <summary>
        /// 渠道代码
        /// </summary>
        public string channel_code { get; set; }
        /// <summary>
        /// 渠道名称
        /// </summary>
        public string channel_name { get; set; }
        /// <summary>
        /// 0父节点
        /// </summary>
        public Int16 parent_id { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public Int16 sort { get; set; }
        /// <summary>
        /// 是否有效
        /// </summary>
        public Int16 isvalid { get; set; }
        /// <summary>
        /// 是否发货同步
        /// </summary>
        public Int16 sync { get; set; }
        /// <summary>
        /// 初审人ID
        /// </summary>
        public UInt32 leader_uid { get; set; }
        /// <summary>
        /// 复审人ID
        /// </summary>
        public UInt32 leader_uid2 { get; set; }
        /// <summary>
        /// 复审起始金额  
        /// </summary>
        public double min_price { get; set; }
        /// <summary>
        /// 平台
        /// </summary>
        public Int16 platform { get; set; }
        /// <summary>
        /// 退货审核人
        /// </summary>
        public Int16 erp_uid { get; set; }

        /// <summary>
        /// 新加的审核人
        /// </summary>
        public UInt32 OrderVerify { get; set; }

        /// <summary>
        /// 初审人ID
        /// </summary>
        public Int16 channel_leader_uid { get; set; }
        /// <summary>
        /// 复审人ID
        /// </summary>
        public Int16 channel_leader_uid2 { get; set; }
    }
}
