using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIVarsTranslators
{
    //See http://merthsoft.com/linkguide/ti83+/tokens.html

    [Obsolete("The token lists are bdly wrote, not complete and are not used.")]
    public enum MainTokens : byte
    {
        None00,             //
        ToDMS,              //>DMS
        ToDec,              //>Dec
        ToFrac,             //>Frac
        Assign,             //->
        BoxPlot,            //BoxPlot
        OpenBracket,        //[
        CloseBracket,       //]
        OpenCurlyBracket,   //{
        CloseCurlyBracket,  //}
        RadianChar,         //Little up r
        DegreeChar,         //°
        Inverse,            //^-1
        Squared,            //^2
        LittleT,            //Little up T
        Cubed,              //^3
        OpenParenthesis,    //(
        CloseParenthesis,   //)
        Round,              //round(
        PxlTest,            //pxl-Test(
        Augment,            //augment
        RowSwap,            //rowSwap(
        RowAdd,             //row+(
        MultRow,            //*row(
        MultRowAdd,         //*row+( 
        Max,                //max(
        Min,                //min(
        RToPr,              //R>Pr(
        RToTheta,           //R>P0(
        PToRx,              //P>Rx(           
        PToRy,              //P>Ry(
        Median,             //median(
        RandM,              //randM(
        Mean,               //mean(
        Solve,              //solve(
        SeqFunction,        //seq(
        FnInt,              //fnInt(
        NDeriv,             //nDeriv(
        None26,             //
        FMin,               //fMin(
        FMax,               //fMax(
        Space,              //_
        QuotationMark,      //"
        Comma,              //,
        ImaginaryI,         //i
        ExclammationPoint,  //!
        CubicReg,           //CubicReg_
        QuartReg,           //QuartReg_
        Number0,            //Numbers
        Number1,
        Number2,
        Number3,
        Number4,
        Number5,
        Number6,
        Number7,
        Number8,
        Number9,
        Dot,                //.
        E,                  //LittleE
        Or,                 // or 
        Xor,                // xor 
        Colon,              //:
        HardReturn,         //
        And,                // and 
        CharA,              //Letters
        CharB,
        CharC,
        CharD,
        CharE,
        CharF,
        CharG,
        CharH,
        CharI,
        CharJ,
        CharK,
        CharL,
        CharM,
        CharN,
        CharO,
        CharP,
        CharQ,
        CharR,
        CharS,
        CharT,
        CharU,
        CharV,
        CharW,
        CharX,
        CharY,
        ChatZ,
        CharTheta,          //Theta character
        Variables5C,        //5C Variables (Matrices)
        Variables5D,        //5D Variables (Lists)
        Variables5E,        //5E Variables
        Prgm,               //prgm
        Variables60,        //60 Variables (Pics)
        Variables61,        //61 Variables (GDBs)
        Variables62,        //62 Variables
        Variables63,        //63 Variables
        Radian,             //Radian
        Degree,             //Degree
        Normal,             //Normal
        Sci,                //Sci
        Eng,                //Eng
        Float,              //Float
        Equals,             //=
        Inferior,           //<
        Superior,           //>
        InferiorOrEquals,   //<=
        SuperiorOrEquals,   //>=
        NotEquals,          //!=
        Plus,               //+
        Minus,              //-
        Ans,                //Ans
        Fix,                //Fix
        Horiz,              //Horiz
        Full,               //Full
        Func,               //Func
        Param,              //Param
        Polar,              //Polar
        Seq,                //Seq
        IndpntAuto,         //IndpntAuto
        IndpntAsk,          //IndpntAsk
        DependAuto,         //DependAuto
        DependAsk,          //DependAsk
        Tokens7E,           //7E Tokens
        LittleSquare,       //
        LittleBigCross,     //
        LittleCross,        //
        Multiply,           //*
        Divide,             // /
        Trace,              //Trace
        ClrDraw,            //ClrDraw
        ZStandard,
        ZTrig,
        ZBox,
        ZoomIn,
        ZoomOut,
        ZSquare,
        ZInteger,
        ZPrevious,
        ZDecimal,
        ZoomStat,
        ZoomRcl,
        PrintScreen,
        ZoomSto,
        Text,
        NPr,
        NCr,
        FnOn,
        FnOff,
        StorePic,
        RecallPic,
        StoreGDB,
        RecallGDB,
        Line,
        Vertical,
        PtOn,
        PtOff,
        PtChange,
        PxlOn,
        PxlOff,
        PxlChange,
        Shade,
        Circle,
        Horizontal,
        Tangent,
        DrawInv,
        DrawF,
        VariablesAA,
        Rand,
        Pi,
        GetKey,
        Apostrophe,
        QuestionMark,
        MinusSign,
        Int,
        Abs,
        Det,
        Identity,
        Dim,
        Sum,
        Prod,
        Not,
        IPart,
        FPart,
        TokensBB,
        SquareRoot,
        CubicRoot,
        Ln,
        EExponent,
        Logarithm,
        TenExponent,
        Sin,
        ArcSin,
        Cos,
        ArcCos,
        Tan,
        ArcTan,
        Sinh,
        ArcSinh,
        Cosh,
        ArcCosh,
        Tanh,
        ArcTanh,
        If,
        Then,
        Else,
        While,
        Repeat,
        For,
        End,
        Return,
        Lbl,
        Goto,
        Pause,
        Stop,
        IS,
        DS,
        Input,
        Prompt,
        Disp,
        DispGraph,
        Output,
        ClrHome,
        Fill,
        SortA,
        SortD,
        DispTable,
        Menu,
        Send,
        Get,
        PlotsOn,
        PlotsOff,
        LittleL,
        Plot1,
        Plot2,
        Plot3,
        NoneEF,
        Exponent,
        XRoot,
        VarStats1,
        VarStats2,
        LinRegAPlusBx,
        ExpReg,
        LnReg,
        PwrReg,
        MedMed,
        QuadReg,
        ClrList,
        ClrTable,
        Histogram,
        XYLine,
        Scatter,
        LinRegAxPlusB
    }

    [Obsolete("The token lists are badly wrote, not complete and are not used.")]
    public static class OtherTokens
    {
        public enum Variables5C : byte
        {
            MatrixA,
            MatrixB,
            MatrixC,
            MatrixD,
            MatrixE,
            MatrixF,
            MatrixG,
            MatrixH,
            MatrixI,
            MatrixJ
        }

        public enum Variables5D : byte
        {
            List1,
            List2,
            List3,
            List4,
            List5,
            List6,
            List7,
            List8,
            List9,
            List0
        }

        public enum Variables5E : byte
        {
            Y1 = 0x10,
            Y2 = 0x11,
            Y3 = 0x12,
            Y4 = 0x13,
            Y5 = 0x14,
            Y6 = 0x15,
            Y7 = 0x16,
            Y8 = 0x17,
            Y9 = 0x18,
            Y0 = 0x19,
            X1T = 0x20,
            Y1T = 0x21,
            X2T = 0x22,
            Y2T = 0x23,
            X3T = 0x24,
            Y3T = 0x25,
            X4T = 0x26,
            Y4T = 0x27,
            X5T = 0x28,
            Y5T = 0x29,
            X6T = 0x2A,
            Y6T = 0x2B,
            R1 = 0x40,
            R2 = 0x41,
            R3 = 0x42,
            R4 = 0x43,
            R5 = 0x44,
            R6 = 0x45,
            U = 0x80,
            V = 0x81
        }

        public enum Variables60 : byte
        {
            Pic1,
            Pic2,
            Pic3,
            Pic4,
            Pic5,
            Pic6,
            Pic7,
            Pic8,
            Pic9,
            Pic0
        }

        public enum Variables61 : byte
        {
            GDB1,
            GDB2,
            GDB3,
            GDB4,
            GDB5,
            GDB6,
            GDB7,
            GDB8,
            GDB9,
            GDB0
        }

        public enum Variables62 : byte
        {
            RegEq = 0x01,
            N = 0x02,
            XMean = 0x03,
            UpperSigmaX = 0x04,
            UpperSigmaXSquared = 0x05,
            Sx = 0x06,
            LowerSigmaX = 0x07,
            MinX = 0x08,
            MaxX = 0x09,
            MinY = 0x0A,
            MaxY = 0x0B,
            YMean = 0x0C,
            UpperSigmaY = 0x0D,
            UpperSigmaYSquared = 0x0E,
            Sy = 0x0F,
            LowerSigmaY = 0x10,
            UpperSigmaXY = 0x11,
            R = 0x12,
            Med = 0x13,
            Q1 = 0x14,
            Q2 = 0x15,
            a = 0x16,
            b = 0x17,
            c = 0x18,
            d = 0x19,
            e = 0x1A,
            X1 = 0x1B,
            X2 = 0x1C,
            X3 = 0x1D,
            Y1 = 0x1E,
            Y2 = 0x1F,
            Y3 = 0x20,
            ItalicN = 0x21,
            P = 0x22,
            Z = 0x23,
            T = 0x24,
            ItalicXSquared = 0x25,
            BigF = 0x26,
            Df = 0x27,
            PHat = 0x28,
            PHat1 = 0x29,
            PHat2 = 0x2A,
            XMean1 = 0x2B,
            Sx1 = 0x2C,
            N1 = 0x2D,
            XMean2 = 0x2E,
            Sx2 = 0x2F,
            N2 = 0x30,
            Sxp = 0x31,
            Lower = 0x32,
            Upper = 0x33,
            S = 0x34,
            LowerRSquared = 0x35,
            RSquared = 0x36,
            DfBis = 0x37,
            SS = 0x38,
            MF = 0x39,
            DfTer = 0x3A,
            SSBis = 0x3B,
            MFBis = 0x3C
        }

        public enum Variables63 : byte
        {
            ZXScl,
            ZYScl,
            XScl,
            YScl,
            UnStart,
            VnStart,
            UnMinus1,
            VnMinus1,
            ZUnStart,
            ZVnStart,
            XMin,
            XMax,
            YMin,
            YMax,
            TMin,
            TMax,
            ThetaMin,
            ThetaMax,
            ZXMin,
            ZXMax,
            ZYMin,
            ZYMax,
            ZThetaMin,
            ZThetaMax,
            ZTMin,
            ZTMax,
            TblMin,
            NMin,
            ZnMin,
            NMax,
            ZnMax,
            NStart,
            DeltaTbl,
            TStep,
            ThetaStep,
            ZTStep,
            ZThetaStep,
            DeltaX,
            DeltaY,
            XFact,
            YFact,
            TblInput,
            BigN,
            IPercent,
            PV,
            PMT,
            FV,
            XRes,
            ZXRes
        }

        public enum VariablesAA : byte
        {
            Str1,
            Str2,
            Str3,
            Str4,
            Str5,
            Str6,
            Str7,
            Str8,
            Str9,
            Str0
        }

        public enum Tokens7E : byte
        {

        }

        public enum TokensBB : byte
        {

        }
    }
}
