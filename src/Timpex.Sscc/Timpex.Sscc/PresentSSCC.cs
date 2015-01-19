using System.Collections.Generic;
using Timpex.Sscc.ByCode;
using Timpex.Sscc.ByPresentation;

namespace Timpex.Sscc
{
    public class PresentSSCC
    {
        private ReadAndExcludeCodes _readAndExclude = ReadAndExcludeCodes.New();
        private CodeRepository _codeRepository = CodeRepository.New();

        private List<Code> _codes = new List<Code>();

        public PresentSSCC(ReadAndExcludeCodes readAndExcludeCodes, CodeRepository codeRepository)
        {
            _readAndExclude = readAndExcludeCodes;
            _codeRepository = codeRepository;
        }

        public List<PresentableCode> PresentCodes()
        {
            throw new System.NotImplementedException();
        }

        private void InitCore()
        {
 
        }

        public PresentSSCC()
        {
        }
    }
}