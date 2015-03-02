using Timpex.Sscc.ByCode;
using Timpex.Sscc.ByIO;

namespace Timpex.Sscc
{
    public class SSCC
    {
        private PresentSSCC _sscc = PresentSSCC.New();
        private CodeWriter _codeWriter = CodeWriter.New();

        public SSCC(PresentSSCC presentSscc, CodeWriter codeWriter)
        {
            _sscc = presentSscc;
            _codeWriter = codeWriter;
        }

        public void Start()
        {
            var codes = _sscc.PresentCodes();
            _codeWriter.Write(codes);
        }

        public SSCC()
        {
        }
    }
}