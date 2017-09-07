using System.Linq;
using HardDriverModel.Enum;
using HardDriverModel.Interface;
using HardDriverPlatform.Factory;

namespace HardDriverPlatform
{
    /// <summary>
    /// 硬件平台管理
    /// </summary>
    public static class HardDriverPlatformConsle
    {
        /// <summary>
        ///asd
        /// </summary>
        private static IdCardFactory idCardFactory { get; } = new IdCardFactory();

        /// <summary>
        /// 摄像头工厂
        /// </summary>
        private static CameraFactory cameraFactory { get; } = new CameraFactory();

        /// <summary>
        /// 初始化身份证读卡
        /// </summary>
        /// <returns>初始化是否成功</returns>
        public static bool initIdCard()
        {
            return idCardFactory.init();
        }

        /// <summary>
        /// 获取身份证读卡实例化对象
        /// </summary>
        /// <returns>实例化对象</returns>
        public static IIdCardReader getIdCardReader(IdCardEnum idCardEnum)
        {
            return idCardFactory.idCardReaders.FirstOrDefault(x=>x.Metadata.idCardEnum == idCardEnum)?.Value;
        }

        /// <summary>
        /// 初始化摄像头驱动
        /// </summary>
        /// <returns>初始化是否成功</returns>
        public static bool initCamera()
        {
            return cameraFactory.init();
        }

        /// <summary>
        /// 获取摄像头实例化对象
        /// </summary>
        /// <returns>实例化对象</returns>
        public static ICamera GetCamera(CameraEnum cameraEnum)
        {
            return cameraFactory.cameras.FirstOrDefault(x => x.Metadata.cameraEnum == cameraEnum)?.Value;
        }
    }
}
