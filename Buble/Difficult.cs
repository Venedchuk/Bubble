using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buble
{
    abstract class Difficult
    {
        public Difficult(int SizeBtn,int Delta, int MonitorSizeH, int MonitorSizeW, HunterButtonMode ModeGame)
        {
            sizeBtn = SizeBtn;
            delta = Delta;
            areaH = MonitorSizeH;
            areaW = MonitorSizeW;
            modeGame = ModeGame;
        }


        private readonly int sizeBtn;
        private readonly int delta;
        private readonly HunterButtonMode modeGame;
        private readonly int areaH;
        private readonly int areaW;
        public abstract bool SaveResult();
    }
    public enum HunterButtonMode
    {
        Easy, Medium, Hard
    }
    class Easy : Difficult
    {
        public Easy(int SizeBtn, int Delta, int MonitorSizeH, int MonitorSizeW, HunterButtonMode ModeGame):base(SizeBtn, Delta, MonitorSizeH, MonitorSizeW, ModeGame)
        { }
        public override bool SaveResult()
        {
            throw new NotImplementedException();
        }
    }

    internal class Medium : Difficult
    {
        public Medium(int SizeBtn, int Delta, int MonitorSizeH, int MonitorSizeW, HunterButtonMode ModeGame) : base(SizeBtn, Delta, MonitorSizeH, MonitorSizeW, ModeGame)
        { }

        public override bool SaveResult()
        {
            throw new NotImplementedException();
        }
    }
}
