using System;
using DevExpress.Xpo;

namespace ReadOnlyApp {
	[NonPersistent]
	public class ReadOnlyObject : XPLiteObject {
        public ReadOnlyObject(Session session) : base(session) { }

		// prevents object saving via BindingManagerBase.EndCurrentEdit
        protected override void DoEndEditAction() { }
	}
}
