using System;
using System.Collections.Generic;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByCode
{
    public class PresentSSCC
    {
        private ReadAndExcludeCodes _readAndExclude = ReadAndExcludeCodes.New();
        private CodeRepository _codeRepository = CodeRepository.New();
        private DtoPresentator _dtoPresentator = DtoPresentator.New();
        private List<Code> _codes = new List<Code>();

        public static Func<PresentSSCC> New = () => new PresentSSCC();

        public PresentSSCC(ReadAndExcludeCodes readAndExcludeCodes, CodeRepository codeRepository, DtoPresentator dtoPresentator)
        {
            _readAndExclude = readAndExcludeCodes;
            _codeRepository = codeRepository;
            _dtoPresentator = dtoPresentator;
        }

        public virtual List<CodeDto> PresentCodes()
        {
            InitCore();
            return _dtoPresentator.Present(_codes);
        }

        private void InitCore()
        {
            var location = _codeRepository.GetLocation();
            _codes = _readAndExclude.Read(location);
        }

        public PresentSSCC()
        {
        }
    }
}