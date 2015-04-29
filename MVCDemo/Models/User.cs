using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid ID { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        [DisplayName("登录名")]
        [StringLength(15,ErrorMessage="名字太长不好记哦~")]
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("密码")]
        [RegularExpression("^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{8,16}$", ErrorMessage = "密码中必须包含字母、数字且总长度在8~16位之间")]
        [DataType(DataType.Password)]
        [Required]
        public string Pwd { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginTimes { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        
    }
}
