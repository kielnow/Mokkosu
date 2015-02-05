﻿namespace Mokkosu
{
    /// <summary>
    /// 式
    /// </summary>
    abstract class SExpr
    {
    }

    /// <summary>
    /// 整数定数
    /// </summary>
    class SConstInt : SExpr
    {
        public int Value { get; private set; }

        public SConstInt(int vlaue)
        {
            Value = Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    /// <summary>
    /// 二項演算子
    /// </summary>
    abstract class SBinop : SExpr
    {
        public SExpr Lhs { get; private set; }
        public SExpr Rhs { get; private set; }

        public SBinop(SExpr lhs, SExpr rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }
    }

    /// <summary>
    /// 整数加算
    /// </summary>
    class SAdd : SBinop
    {
        public SAdd(SExpr lhs, SExpr rhs)
            : base(lhs, rhs)
        {
        }

        public override string ToString()
        {
            return string.Format("({0} + {1})", Lhs, Rhs);
        }
    }

    /// <summary>
    /// 整数減算
    /// </summary>
    class SSub : SBinop
    {
        public SSub(SExpr lhs, SExpr rhs)
            : base(lhs, rhs)
        {
        }

        public override string ToString()
        {
            return string.Format("({0} - {1})", Lhs, Rhs);
        }
    }

    /// <summary>
    /// 整数乗算
    /// </summary>
    class SMul : SBinop
    {
        public SMul(SExpr lhs, SExpr rhs)
            : base(lhs, rhs)
        {
        }

        public override string ToString()
        {
            return string.Format("({0} * {1})", Lhs, Rhs);
        }
    }

    /// <summary>
    /// 整数除算
    /// </summary>
    class SDiv : SBinop
    {
        public SDiv(SExpr lhs, SExpr rhs)
            : base(lhs, rhs)
        {
        }

        public override string ToString()
        {
            return string.Format("({0} / {1})", Lhs, Rhs);
        }
    }

    /// <summary>
    /// 等しい
    /// </summary>
    class SEq : SBinop
    {
        public SEq(SExpr lhs, SExpr rhs)
            : base(lhs, rhs)
        {
        }

        public override string ToString()
        {
            return string.Format("({0} == {1})", Lhs, Rhs);
        }
    }

    /// <summary>
    /// 変数
    /// </summary>
    class SVar : SExpr
    {
        public string Name { get; private set; }

        public SVar(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// ラムダ式
    /// </summary>
    class SFun : SExpr
    {
        public string ArgName { get; private set; }
        public SExpr Body { get; private set; }

        public SFun(string arg_name, SExpr body)
        {
            ArgName = arg_name;
            Body = body;
        }

        public override string ToString()
        {
            return string.Format("(\\{0} -> {1})", ArgName, Body);
        }
    }

    /// <summary>
    /// 関数適用
    /// </summary>
    class SApp : SExpr
    {
        public SExpr FunExpr { get; private set; }
        public SExpr ArgExpr { get; private set; }

        public SApp(SExpr fun_expr, SExpr arg_expr)
        {
            FunExpr = fun_expr;
            ArgExpr = arg_expr;
        }

        public override string ToString()
        {
            return string.Format("({0} {1})", FunExpr, ArgExpr);
        }
    }

    class SLet : SExpr
    {
        public string VarName { get; set; }
        public SExpr E1 { get; private set; }
        public SExpr E2 { get; private set; }

        public SLet(string var_name, SExpr e1, SExpr e2)
        {
            VarName = var_name;
            E1 = e1;
            E2 = e2;
        }

        public override string ToString()
        {
            return string.Format("(let {0} = {1} in {2})", VarName, E1, E2);
        }
    }

    /// <summary>
    /// If式
    /// </summary>
    class SIf : SExpr
    {
        public SExpr CondExpr { get; private set; }
        public SExpr ThenExpr { get; private set; }
        public SExpr ElseExpr { get; private set; }

        public SIf(SExpr cond_expr, SExpr then_expr, SExpr else_expr)
        {
            CondExpr = cond_expr;
            ThenExpr = then_expr;
            ElseExpr = else_expr;
        }

        public override string ToString()
        {
            return string.Format("(if {0} then {1} else {2})", CondExpr, ThenExpr, ElseExpr);
        }
    }

    /// <summary>
    /// Print式
    /// </summary>
    class SPrint : SExpr
    {
        public SExpr Body { get; private set; }

        public SPrint(SExpr body)
        {
            Body = body;
        }

        public override string ToString()
        {
            return string.Format("(print {0})", Body);
        }
    }
}
