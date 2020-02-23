using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Danmaku.Model;

namespace Danmaku.Utils.BiliBili
{
    public interface IBiliBiliHelp
    {
        /// <summary>
        /// 获取视频Cid和分P信息
        /// </summary>
        /// <param name="aid">视频的aid</param>
        /// <returns>Page信息</returns>
        Task<List<BilibiliPage>> GetBilibiliPage(string aid);

        /// <summary>
        /// 获取Cid
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="p">分p</param>
        /// <returns>cid</returns>
        int GetCid(List<BilibiliPage> pages, int p);

        /// <summary>
        /// 获取Cid
        /// </summary>
        /// <param name="aid">视频的aid</param>
        /// <param name="p">分p</param>
        /// <returns>cid</returns>
        Task<int> GetCid(string aid, int p);

        /// <summary>
        /// 获取弹幕列表
        /// </summary>
        /// <param name="cid">视频的cid</param>
        /// <returns>弹幕列表</returns>
        Task<List<DanmakuData>> GetBiDanmaku(string cid);

        /// <summary>
        /// 获取历史弹幕列表
        /// </summary>
        /// <param name="cid">视频的cid</param>
        /// <param name="date">历史日期</param>
        /// <returns>弹幕列表</returns>
        Task<List<DanmakuData>> GetBiDanmaku(string cid, string[] date);

        /// <summary>
        /// 获取弹幕列表
        /// </summary>
        /// <param name="cid">视频的cid</param>
        /// <returns>原始弹幕</returns>
        Task<Stream> GetBiDanmakuRaw(string cid);
    }
}
