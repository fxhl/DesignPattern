using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class LoadBalancer
    {
        private static LoadBalancer _loadBalancer = null;
        //创建服务器集合
        private ArrayList _serverList;

        private LoadBalancer()
        {
            _serverList = new ArrayList();
        }
        //公有静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            if (_loadBalancer == null)
            {
                _loadBalancer = new LoadBalancer();
            }
            return _loadBalancer;
        }
        //增加服务器
        public void AddServer(string server)
        {
            _serverList.Add(server);
        }

        //删除服务器
        public void RemoveServer(string server)
        {
            _serverList.Remove(server);
        }

        //使用Random类随机获取服务器
        public string GetServer()
        {
            Random random = new Random();
            int i = random.Next(_serverList.Count);
            return _serverList[i].ToString();
        }
    }
}
