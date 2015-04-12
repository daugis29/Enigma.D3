using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXButton : UXLabel
	{
		public new const int SizeOf = 0xE40; //3648
		public new const int VTable = 0x018265A0;

		public int _xB78 { get { return Read<int>(0xB78); } }
		public int xB80_Neg1 { get { return Read<int>(0xB80); } }
		public int xB84_Neg1 { get { return Read<int>(0xB84); } }
		public int xB88_Neg1 { get { return Read<int>(0xB88); } }
		public int xB8C_Neg1 { get { return Read<int>(0xB8C); } }
		public int xB90_Neg1 { get { return Read<int>(0xB90); } }
		public int xB94_Neg1 { get { return Read<int>(0xB94); } }
		public int xB98_Neg1 { get { return Read<int>(0xB98); } }
		public int xB9C_Neg1 { get { return Read<int>(0xB9C); } }
		public int xBA0_Neg1 { get { return Read<int>(0xBA0); } }
		public int xBA4_Neg1 { get { return Read<int>(0xBA4); } }
		public int xBA8_Neg1 { get { return Read<int>(0xBA8); } }
		public int xBAC_Neg1 { get { return Read<int>(0xBAC); } }
		public int _xBB0 { get { return Read<int>(0xBB0); } }
		public int xBB4_Neg1 { get { return Read<int>(0xBB4); } }
		public int xBB8_Neg1 { get { return Read<int>(0xBB8); } }
		public int xBBC_Neg1 { get { return Read<int>(0xBBC); } }
		public int xBC0_Neg1 { get { return Read<int>(0xBC0); } }
		public int _xBC4 { get { return Read<int>(0xBC4); } }
		public int _xBC8 { get { return Read<int>(0xBC8); } }
		public int _xBCC { get { return Read<int>(0xBCC); } }
		public int _xBD0 { get { return Read<int>(0xBD0); } }
		public int _xBD4 { get { return Read<int>(0xBD4); } }
		public int _xBD8 { get { return Read<int>(0xBD8); } }
		public int _xBDC { get { return Read<int>(0xBDC); } }
		public int _xBE0 { get { return Read<int>(0xBE0); } }
		public int _xBE4 { get { return Read<int>(0xBE4); } }
		public int _xBE8 { get { return Read<int>(0xBE8); } }
		public int _xBEC { get { return Read<int>(0xBEC); } }
		public int _xBF0 { get { return Read<int>(0xBF0); } }
		public int _xBF4 { get { return Read<int>(0xBF4); } }
		public int _xBF8 { get { return Read<int>(0xBF8); } }
		public int _xBFC { get { return Read<int>(0xBFC); } }
		public int _xC00 { get { return Read<int>(0xC00); } }
		public int _xC04 { get { return Read<int>(0xC04); } }
		public int _xC08 { get { return Read<int>(0xC08); } }
		public int _xC0C { get { return Read<int>(0xC0C); } }
		public int _xC10 { get { return Read<int>(0xC10); } }
		public int _xC14 { get { return Read<int>(0xC14); } }
		public int _xC18 { get { return Read<int>(0xC18); } }
		public int _xC1C { get { return Read<int>(0xC1C); } }
		public int _xC20 { get { return Read<int>(0xC20); } }
		public int _xC24 { get { return Read<int>(0xC24); } }
		public int _xC28 { get { return Read<int>(0xC28); } }
		public int _xC2C { get { return Read<int>(0xC2C); } }
		public int _xC30 { get { return Read<int>(0xC30); } }
		public int _xC34 { get { return Read<int>(0xC34); } }
		public int _xC38 { get { return Read<int>(0xC38); } }
		public int _xC3C { get { return Read<int>(0xC3C); } }
		public int _xC40 { get { return Read<int>(0xC40); } }
		public int _xC44 { get { return Read<int>(0xC44); } }
		public int _xC48 { get { return Read<int>(0xC48); } }
		public int _xC4C { get { return Read<int>(0xC4C); } }
		public int _xC50 { get { return Read<int>(0xC50); } }
		public int _xC54 { get { return Read<int>(0xC54); } }
		public int _xC58 { get { return Read<int>(0xC58); } }
		public int _xC5C { get { return Read<int>(0xC5C); } }
		public int _xC60 { get { return Read<int>(0xC60); } }
		public int _xC64 { get { return Read<int>(0xC64); } }
		public int _xC68 { get { return Read<int>(0xC68); } }
		public int _xC6C { get { return Read<int>(0xC6C); } }
		public int _xC70 { get { return Read<int>(0xC70); } }
		public int _xC74 { get { return Read<int>(0xC74); } }
		public int _xC78 { get { return Read<int>(0xC78); } }
		public int _xC7C { get { return Read<int>(0xC7C); } }
		public int _xC80 { get { return Read<int>(0xC80); } }
		public int _xC84 { get { return Read<int>(0xC84); } }
		public int _xC88 { get { return Read<int>(0xC88); } }
		public int _xC8C { get { return Read<int>(0xC8C); } }
		public int _xC90 { get { return Read<int>(0xC90); } }
		public int _xC94 { get { return Read<int>(0xC94); } }
		public int _xC98 { get { return Read<int>(0xC98); } }
		public int _xC9C { get { return Read<int>(0xC9C); } }
		public int _xCA0 { get { return Read<int>(0xCA0); } }
		public int _xCA4 { get { return Read<int>(0xCA4); } }
		public int _xCA8 { get { return Read<int>(0xCA8); } }
		public int _xCAC { get { return Read<int>(0xCAC); } }
		public int _xCB0 { get { return Read<int>(0xCB0); } }
		public int _xCB4 { get { return Read<int>(0xCB4); } }
		public int _xCB8 { get { return Read<int>(0xCB8); } }
		public int _xCBC { get { return Read<int>(0xCBC); } }
		public int _xCC0 { get { return Read<int>(0xCC0); } }
		public int _xCC4 { get { return Read<int>(0xCC4); } }
		public int _xCC8 { get { return Read<int>(0xCC8); } }
		public int _xCCC { get { return Read<int>(0xCCC); } }
		public int _xCD0 { get { return Read<int>(0xCD0); } }
		public int _xCD4 { get { return Read<int>(0xCD4); } }
		public int _xCD8 { get { return Read<int>(0xCD8); } }
		public int _xCDC { get { return Read<int>(0xCDC); } }
		public int _xCE0 { get { return Read<int>(0xCE0); } }
		public int _xCE4 { get { return Read<int>(0xCE4); } }
		public int _xCE8 { get { return Read<int>(0xCE8); } }
		public int _xCEC { get { return Read<int>(0xCEC); } }
		public int _xCF0 { get { return Read<int>(0xCF0); } }
		public int _xCF4 { get { return Read<int>(0xCF4); } }
		public int _xCF8 { get { return Read<int>(0xCF8); } }
		public int _xCFC { get { return Read<int>(0xCFC); } }
		public int _xD00 { get { return Read<int>(0xD00); } }
		public int _xD04 { get { return Read<int>(0xD04); } }
		public int _xD08 { get { return Read<int>(0xD08); } }
		public int _xD0C { get { return Read<int>(0xD0C); } }
		public int _xD10 { get { return Read<int>(0xD10); } }
		public int _xD14 { get { return Read<int>(0xD14); } }
		public int _xD18 { get { return Read<int>(0xD18); } }
		public int _xD1C { get { return Read<int>(0xD1C); } }
		public int _xD20 { get { return Read<int>(0xD20); } }
		public int _xD24 { get { return Read<int>(0xD24); } }
		public int _xD28 { get { return Read<int>(0xD28); } }
		public int _xD2C { get { return Read<int>(0xD2C); } }
		public int _xD30 { get { return Read<int>(0xD30); } }
		public int _xD34 { get { return Read<int>(0xD34); } }
		public int _xD38 { get { return Read<int>(0xD38); } }
		public int _xD3C { get { return Read<int>(0xD3C); } }
		public int _xD40 { get { return Read<int>(0xD40); } }
		public int _xD44 { get { return Read<int>(0xD44); } }
		public int _xD48 { get { return Read<int>(0xD48); } }
		public int _xD4C { get { return Read<int>(0xD4C); } }
		public int _xD50 { get { return Read<int>(0xD50); } }
		public int _xD54 { get { return Read<int>(0xD54); } }
		public int _xD58 { get { return Read<int>(0xD58); } }
		public int _xD5C { get { return Read<int>(0xD5C); } }
		public int _xD60 { get { return Read<int>(0xD60); } }
		public int _xD64 { get { return Read<int>(0xD64); } }
		public int _xD68 { get { return Read<int>(0xD68); } }
		public int _xD6C { get { return Read<int>(0xD6C); } }
		public int _xD70 { get { return Read<int>(0xD70); } }
		public int _xD74 { get { return Read<int>(0xD74); } }
		public int _xD78 { get { return Read<int>(0xD78); } }
		public int _xD7C { get { return Read<int>(0xD7C); } }
		public int _xD80 { get { return Read<int>(0xD80); } }
		public int _xD84 { get { return Read<int>(0xD84); } }
		public int _xD88 { get { return Read<int>(0xD88); } }
		public int _xD8C { get { return Read<int>(0xD8C); } }
		public int _xD90 { get { return Read<int>(0xD90); } }
		public int _xD94 { get { return Read<int>(0xD94); } }
		public int _xD98 { get { return Read<int>(0xD98); } }
		public int _xD9C { get { return Read<int>(0xD9C); } }
		public int _xDA0 { get { return Read<int>(0xDA0); } }
		public int _xDA4 { get { return Read<int>(0xDA4); } }
		public int _xDA8 { get { return Read<int>(0xDA8); } }
		public int _xDAC { get { return Read<int>(0xDAC); } }
		public int _xDB0 { get { return Read<int>(0xDB0); } }
		public int _xDB4 { get { return Read<int>(0xDB4); } }
		public int _xDB8 { get { return Read<int>(0xDB8); } }
		public int _xDBC { get { return Read<int>(0xDBC); } }
		public int _xDC0 { get { return Read<int>(0xDC0); } }
		public int _xDC4 { get { return Read<int>(0xDC4); } }
		public int _xDC8 { get { return Read<int>(0xDC8); } }
		public int _xDCC { get { return Read<int>(0xDCC); } }
		public int _xDD0 { get { return Read<int>(0xDD0); } }
		public int _xDD4 { get { return Read<int>(0xDD4); } }
		public int _xDD8 { get { return Read<int>(0xDD8); } }
		public int _xDDC { get { return Read<int>(0xDDC); } }
		public int _xDE0 { get { return Read<int>(0xDE0); } }
		public int _xDE4 { get { return Read<int>(0xDE4); } }
		public int _xDE8 { get { return Read<int>(0xDE8); } }
		public int _xDEC { get { return Read<int>(0xDEC); } }
		public int _xDF0 { get { return Read<int>(0xDF0); } }
		public int _xDF4 { get { return Read<int>(0xDF4); } }
		public int _xDF8 { get { return Read<int>(0xDF8); } }
		public int _xDFC { get { return Read<int>(0xDFC); } }
		public int _xE00 { get { return Read<int>(0xE00); } }
		public int _xE04 { get { return Read<int>(0xE04); } }
		public int _xE08 { get { return Read<int>(0xE08); } }
		public int _xE0C { get { return Read<int>(0xE0C); } }
		public int _xE10 { get { return Read<int>(0xE10); } }
		public int _xE14 { get { return Read<int>(0xE14); } }
		public int _xE18 { get { return Read<int>(0xE18); } }
		public int _xE1C { get { return Read<int>(0xE1C); } }
		public int _xE20 { get { return Read<int>(0xE20); } }
		public int _xE24 { get { return Read<int>(0xE24); } }
		public int _xE28 { get { return Read<int>(0xE28); } }
		public int _xE2C { get { return Read<int>(0xE2C); } }
		public int _xE30 { get { return Read<int>(0xE30); } }
		public int _xE34 { get { return Read<int>(0xE34); } }
		public int _xE38 { get { return Read<int>(0xE38); } }
		public int _xE3C { get { return Read<int>(0xE3C); } }
	}
}
