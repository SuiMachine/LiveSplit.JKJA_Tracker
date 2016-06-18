using LiveSplit.UI.Components;
using System;

namespace LiveSplit.JKJA_Tracker
{
    public class Factory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "JKJA_Tracker"; }
        }
        public ComponentCategory Category
        {
            get { return ComponentCategory.Information; }
        }
        public string Description
        {
            get { return "Shows Jedi Knight Jedi Academy Stats"; }
        }
        public IComponent Create(Model.LiveSplitState state)
        {
            return new Component(state);
        }
        public string UpdateName
        {
            get { return ComponentName; }
        }
        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/SuiMachine/LiveSplit.JKJA_Tracker/master/"; }
        }
        public Version Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; }
        }
        public string XMLURL
        {
            get { return UpdateURL + "Components/update.LiveSplit.JKJA_Tracker.xml"; }
        }
    }
}