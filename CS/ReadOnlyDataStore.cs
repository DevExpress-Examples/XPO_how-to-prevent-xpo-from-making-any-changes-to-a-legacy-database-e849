using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;

namespace ReadOnlyApp {

    class ReadOnlyDataStore : DataStoreSerialized {
        public ReadOnlyDataStore(IDataStore nestedProvider) : base(nestedProvider) { }
        protected override ModificationResult ProcessModifyData(params ModificationStatement[] dmlStatements) {
            throw new InvalidOperationException("Cannot modify data.");
        }
    }
}
