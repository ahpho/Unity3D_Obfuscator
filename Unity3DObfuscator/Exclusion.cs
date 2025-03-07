﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity3DObfuscator
{
    public class Exclusion
    {
        //Execution Order of Event Functions in Unity. Feel free to add functions that you think they are missing.
        private static readonly List<string> unityFunctions = new List<string>(new string[] { "Awake", "OnEnable", "OnDisable", "OnLevelWasLoaded", "OnApplicationPause", "Start", "Update", "FixedUpdate", "LateUpdate", "OnPreCull", "OnBecameVisible", "OnBecameInvisible", "OnWillRenderObject", "OnPreRender", "OnRenderObject", "OnPostRender", "OnRenderImage", "OnGUI", "OnDrawGizmos", "OnDestroy", "OnApplicationQuit", "OnTriggerEnter", "OnTriggerExit", "OnCollisionEnter", "OnCollisionExit", "OnMouseClick", "OnMouseDown", "OnMouseUp" });

        private static readonly List<string> types = new List<string>(new string[0]);

        //Excluded types.
        private static readonly List<string> exludedTypes = new List<string>(new string[0]);
        //Excluded methods.
        private static readonly List<string> exludedMethods = new List<string>(new string[0]);

        //Excluded strings.
        private static readonly List<string> excludedStrings = new List<string>(new string[0]);

        //List of strings in the assembly
        private static readonly List<string> strings = new List<string>(new string[0]);

        //The properties are just return functions of every list.
        public static List<string> UnityFunctions => unityFunctions;

        public static List<string> Types => types;

        public static List<string> ExludedTypes => exludedTypes;

        public static List<string> ExludedMethods => exludedMethods;

        public static List<string> ExcludedStrings => excludedStrings;

        public static List<string> Strings => strings;
    }
}