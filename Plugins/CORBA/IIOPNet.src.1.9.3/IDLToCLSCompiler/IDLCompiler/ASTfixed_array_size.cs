/* Generated By:JJTree: Do not edit this line. ASTfixed_array_size.cs */

using System;

namespace parser {

public class ASTfixed_array_size : SimpleNode {
  public ASTfixed_array_size(int id) : base(id) {
  }

  public ASTfixed_array_size(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
}


}
