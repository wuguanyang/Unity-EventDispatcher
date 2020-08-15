using System;

using System.Collections.Generic;
/// <summary>
/// 事件调度器
/// </summary>
/// <typeparam name="T">类型</typeparam>
/// <typeparam name="P">委托参数</typeparam>
/// <typeparam name="X">事件ID或者枚举</typeparam>
public class EventDispatcher<P, X> : Singleton<EventDispatcher<P, X>> {

    protected EventDispatcher() {

    }

    Dictionary<X, List<Action<P>>> dic = new Dictionary<X, List<Action<P>>>();

    public void AddListener(X key, Action<P> handle) {
        if (dic.ContainsKey(key)) {
            dic[key].Add(handle);
        }
        else {
            List<Action<P>> actions = new List<Action<P>>();
            actions.Add(handle);
            dic[key] = actions;
        }
    }

    public void RemoveListener(X key, Action<P> handle) {
        if (dic.ContainsKey(key)) {
            List<Action<P>> actions = dic[key];
            actions.Remove(handle);
            if (actions.Count == 0) {
                dic.Remove(key);
            }
        }
    }

    public void BroadCast(X key, P p) {
        if (dic.ContainsKey(key)) {
            List<Action<P>> actions = dic[key];
            if (actions != null && actions.Count > 0) {
                foreach (var item in actions) {
                    if (item != null) {
                        item(p);
                    }
                }
            }
        }
    }
}


