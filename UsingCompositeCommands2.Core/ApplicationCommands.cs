using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace UsingCompositeCommands2.Core {
    public interface IApplicationCommands {
        CompositeCommand CompositeCommand { get; }
    }
    public class ApplicationCommands : IApplicationCommands {
        //只执行激活的命令，则下面构造函数为true
        private CompositeCommand _compositeCommand = new CompositeCommand(true);

        public CompositeCommand CompositeCommand {
            get { return _compositeCommand; }
        }
    }
}
