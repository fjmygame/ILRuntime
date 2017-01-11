﻿using System;
using System.Collections.Generic;
using System.Reflection;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Int32_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Int32);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("CompareTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CompareTo_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CompareTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CompareTo_1);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_3);
            args = new Type[]{};
            method = type.GetMethod("GetHashCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHashCode_4);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_6);
            args = new Type[]{typeof(System.IFormatProvider)};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_7);
            args = new Type[]{typeof(System.String), typeof(System.IFormatProvider)};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_8);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Parse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Parse_9);
            args = new Type[]{typeof(System.String), typeof(System.Globalization.NumberStyles)};
            method = type.GetMethod("Parse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Parse_10);
            args = new Type[]{typeof(System.String), typeof(System.IFormatProvider)};
            method = type.GetMethod("Parse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Parse_11);
            args = new Type[]{typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider)};
            method = type.GetMethod("Parse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Parse_12);
            args = new Type[]{typeof(System.String), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("TryParse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryParse_13);
            args = new Type[]{typeof(System.String), typeof(System.Globalization.NumberStyles), typeof(System.IFormatProvider), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("TryParse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryParse_14);
            args = new Type[]{};
            method = type.GetMethod("GetTypeCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTypeCode_15);


        }

        static StackObject* CompareTo_0(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object value = (System.Object)typeof(System.Object).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.CompareTo(value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CompareTo_1(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.CompareTo(value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Equals_2(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object obj = (System.Object)typeof(System.Object).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.Equals(obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Equals_3(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 obj = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.Equals(obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetHashCode_4(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.GetHashCode();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ToString_5(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_6(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.ToString(format);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_7(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IFormatProvider provider = (System.IFormatProvider)typeof(System.IFormatProvider).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.ToString(provider);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_8(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IFormatProvider provider = (System.IFormatProvider)typeof(System.IFormatProvider).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String format = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.ToString(format, provider);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Parse_9(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String s = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.Int32.Parse(s);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Parse_10(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Globalization.NumberStyles style = (System.Globalization.NumberStyles)typeof(System.Globalization.NumberStyles).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String s = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.Int32.Parse(s, style);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Parse_11(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IFormatProvider provider = (System.IFormatProvider)typeof(System.IFormatProvider).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String s = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.Int32.Parse(s, provider);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Parse_12(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.IFormatProvider provider = (System.IFormatProvider)typeof(System.IFormatProvider).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Globalization.NumberStyles style = (System.Globalization.NumberStyles)typeof(System.Globalization.NumberStyles).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String s = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.Int32.Parse(s, style, provider);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* TryParse_13(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 result = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String s = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.Int32.TryParse(s, out result);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var dst = *(StackObject**)&ptr_of_this_method->Value;
                        dst->ObjectType = ObjectTypes.Integer;
                        dst->Value = result;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = result;
                        }
                        else
                        {
                            var t = domain.GetType(___obj.GetType()) as CLRType;
                            t.Fields[ptr_of_this_method->ValueLow].SetValue(___obj, result);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = result;
                        }
                        else
                        {
                            ((CLRType)t).Fields[ptr_of_this_method->ValueLow].SetValue(null, result);
                        }
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryParse_14(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 result = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.IFormatProvider provider = (System.IFormatProvider)typeof(System.IFormatProvider).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Globalization.NumberStyles style = (System.Globalization.NumberStyles)typeof(System.Globalization.NumberStyles).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String s = (System.String)typeof(System.String).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.Int32.TryParse(s, style, provider, out result);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var dst = *(StackObject**)&ptr_of_this_method->Value;
                        dst->ObjectType = ObjectTypes.Integer;
                        dst->Value = result;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = result;
                        }
                        else
                        {
                            var t = domain.GetType(___obj.GetType()) as CLRType;
                            t.Fields[ptr_of_this_method->ValueLow].SetValue(___obj, result);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = result;
                        }
                        else
                        {
                            ((CLRType)t).Fields[ptr_of_this_method->ValueLow].SetValue(null, result);
                        }
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetTypeCode_15(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 instance_of_this_method;
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.FieldReference:
                    {
                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];
                        if(instance_of_fieldReference is ILTypeInstance)
                        {
                            instance_of_this_method = (System.Int32)((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow];
                        }
                        else
                        {
                            var t = domain.GetType(instance_of_fieldReference.GetType()) as CLRType;
                            instance_of_this_method = (System.Int32)t.Fields[ptr_of_this_method->ValueLow].GetValue(instance_of_fieldReference);
                        }
                    }
                    break;
                default:
                    instance_of_this_method = ptr_of_this_method->Value;
                    break;
            }

            var result_of_this_method = instance_of_this_method.GetTypeCode();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
