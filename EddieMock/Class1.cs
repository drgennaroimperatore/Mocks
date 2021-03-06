﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;


//Adapted from tutorial :
//https://crosp.net/blog/software-development/mobile/android/creating-custom-radio-groups-radio-buttons-android/

namespace EddieMock
{
    class CustomRadioButton : RelativeLayout
    {
        //Context
        private Context m_Context;

        //views in our custom rbs
        //the original tutorial consisted of a unit, what i want is a pic of an animal
        private TextView m_TextView;

        //attribute values 
        private string m_Value;
        private int m_TextColour;
        private int m_PressedTextColour;

        //others
        private Drawable m_intialBackgroundDrawable;
        private bool m_Checked;
        private IOnClickListener m_onClickListener;
        private IOnTouchListener onTouchListener;


        public CustomRadioButton(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            m_Context = context;
            setupView();
        }

        private void setupView()
        {

        }

        private void inflateView()

        {
            LayoutInflater inflater = LayoutInflater.From(m_Context);

        }
    }
}