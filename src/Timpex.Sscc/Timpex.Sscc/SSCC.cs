using Timpex.Sscc.ByCode;
using Timpex.Sscc.ByIO;

namespace Timpex.Sscc
{
    public class SSCC
    {
        private PresentSSCC _sscc = PresentSSCC.New();
        private ResolveAndWrite _resolveAndWrite = ResolveAndWrite.New();

        public SSCC(PresentSSCC presentSscc, ResolveAndWrite resolveAndWrite)
        {
            _sscc = presentSscc;
            _resolveAndWrite = resolveAndWrite;
        }

        public void Start()
        {
            var dtos = _sscc.PresentCodes();
            _resolveAndWrite.Execute(dtos);
        }

        public SSCC()
        {
        }
    }
}