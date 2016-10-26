﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionFramework.Internal {
    class ReflectionHelperAssemblyKey {
        public static readonly byte[] strongKeyPair = new byte[] {
            0x07, 0x02, 0x00, 0x00, 0x00, 0x24, 0x00, 0x00, 0x52, 0x53, 0x41, 0x32, 0x00, 0x04, 0x00, 0x00,
            0x01, 0x00, 0x01, 0x00, 0x75, 0x8f, 0x95, 0xf5, 0xe2, 0x3e, 0x5e, 0x7f, 0x81, 0x91, 0x59, 0x9b,
            0xa1, 0xe7, 0x26, 0x20, 0x93, 0xb5, 0xc8, 0xca, 0x5d, 0x32, 0x9e, 0x36, 0x0a, 0x8d, 0x61, 0xf3,
            0xb9, 0x4f, 0x4a, 0xc2, 0x33, 0x15, 0x70, 0x31, 0x41, 0xec, 0xf1, 0x51, 0x72, 0x3f, 0xbf, 0xcf,
            0x6a, 0x1e, 0x7f, 0x09, 0xf2, 0xc3, 0xf3, 0xb8, 0x24, 0x06, 0x82, 0x93, 0x21, 0x64, 0x82, 0xb4,
            0x32, 0x45, 0x96, 0x72, 0x9e, 0x7d, 0x29, 0x73, 0xe7, 0x36, 0x60, 0xaa, 0x11, 0xd5, 0x9c, 0x2b,
            0xd3, 0x6d, 0x66, 0xb8, 0x79, 0x9f, 0xaa, 0x68, 0x02, 0xd2, 0x93, 0x82, 0xd3, 0x8c, 0xfb, 0xd9,
            0x63, 0x4c, 0x10, 0x42, 0x4d, 0x1b, 0xfd, 0x43, 0x85, 0x47, 0x69, 0xfe, 0x87, 0x5b, 0xdd, 0x19,
            0x4a, 0x55, 0x27, 0xb4, 0x5b, 0x61, 0xa2, 0xbb, 0xeb, 0xb8, 0x4d, 0x70, 0x18, 0x0c, 0xa4, 0x86,
            0x74, 0x89, 0x01, 0xf6, 0xa9, 0xd8, 0x36, 0xab, 0x01, 0xc2, 0x4a, 0xc0, 0xbb, 0x33, 0xc9, 0xec,
            0x25, 0xeb, 0xa2, 0x2c, 0xa9, 0x09, 0x90, 0xdb, 0x95, 0x85, 0x7d, 0x44, 0x35, 0xe7, 0x2b, 0x7d,
            0xd9, 0x89, 0x90, 0x71, 0x8a, 0x54, 0xe9, 0x8a, 0xfd, 0x93, 0x2d, 0xeb, 0x69, 0x15, 0xe5, 0x9e,
            0xb1, 0xcf, 0x61, 0xa5, 0xb5, 0xed, 0x3e, 0xcc, 0x62, 0xf5, 0x11, 0xf0, 0xc7, 0x83, 0x14, 0x6e,
            0x09, 0x9f, 0x38, 0xfb, 0xed, 0x03, 0x3d, 0x17, 0x85, 0xcd, 0x55, 0x5a, 0x7f, 0xe2, 0xfa, 0x52,
            0x9a, 0xbf, 0xab, 0xbc, 0x6b, 0x02, 0xa3, 0xd0, 0x27, 0x47, 0x93, 0xcf, 0x15, 0x96, 0x77, 0x1e,
            0x8d, 0xdc, 0x27, 0xee, 0x7b, 0x70, 0x7a, 0x84, 0x53, 0x65, 0x84, 0xfc, 0x1d, 0xda, 0x19, 0x03,
            0xaf, 0x33, 0xca, 0x53, 0x97, 0x71, 0x72, 0x13, 0x92, 0x3f, 0xdd, 0x3a, 0x0d, 0x13, 0x92, 0xce,
            0xeb, 0x84, 0xaf, 0xfa, 0xe1, 0x0d, 0x50, 0x29, 0x58, 0x6f, 0x2d, 0x7a, 0x5c, 0xf5, 0xe3, 0xfa,
            0xd8, 0x11, 0x84, 0xde, 0xf8, 0xef, 0x94, 0x1c, 0x0f, 0xe7, 0xcd, 0xb1, 0x93, 0x62, 0x97, 0x99,
            0x87, 0x3b, 0x09, 0xa6, 0x28, 0x76, 0x4d, 0xaf, 0xc2, 0xc6, 0x01, 0xdf, 0xf3, 0x7e, 0x65, 0x09,
            0x1c, 0xa0, 0xf6, 0x9e, 0xa0, 0x5d, 0x96, 0x00, 0x36, 0x96, 0xc1, 0x73, 0x0c, 0x0e, 0x0f, 0xed,
            0x3e, 0x71, 0xec, 0x96, 0x19, 0xb6, 0x77, 0x4e, 0xae, 0x2b, 0x8e, 0x59, 0x55, 0x1e, 0x7c, 0x7b,
            0x44, 0x52, 0x95, 0x65, 0x69, 0x8f, 0xde, 0x0a, 0xe3, 0x50, 0x7f, 0xf3, 0xe3, 0xde, 0x71, 0x13,
            0x13, 0x48, 0x41, 0x3b, 0xa0, 0x38, 0x95, 0xf0, 0x92, 0x64, 0x9f, 0x34, 0x70, 0x77, 0x33, 0x64,
            0xf8, 0xb0, 0x02, 0x7d, 0x4e, 0xac, 0x3a, 0x7e, 0xe9, 0xae, 0xd4, 0x6a, 0x81, 0x6c, 0x51, 0x2e,
            0x0f, 0x12, 0x6c, 0xc9, 0x10, 0x76, 0xd0, 0xa0, 0x54, 0x0a, 0xec, 0x5e, 0xc6, 0x23, 0x72, 0x57,
            0x3c, 0x3d, 0x0c, 0x07, 0x6b, 0x5d, 0x00, 0x7b, 0xed, 0x53, 0x4a, 0xb5, 0xcf, 0x1d, 0x04, 0xe4,
            0xf8, 0xe2, 0x10, 0xca, 0x21, 0xcc, 0x13, 0xc5, 0x1f, 0x53, 0xd9, 0x9f, 0x3a, 0xea, 0xdd, 0xb6,
            0xa9, 0x36, 0xee, 0x0d, 0x04, 0xe8, 0x41, 0x97, 0xb4, 0x5b, 0xd8, 0x31, 0x09, 0x18, 0xd1, 0x38,
            0x6d, 0xb1, 0x85, 0x64, 0xa1, 0xc9, 0xd3, 0xbf, 0xe8, 0x45, 0xd8, 0x23, 0x12, 0xd5, 0xc0, 0x82,
            0xad, 0x55, 0x74, 0x6d, 0xcf, 0x8d, 0xa1, 0x43, 0xf2, 0x5d, 0xff, 0xd4, 0xf6, 0xc2, 0xc2, 0x39,
            0x3a, 0x83, 0x31, 0x47, 0x0e, 0x9f, 0xa8, 0x82, 0x00, 0x09, 0x50, 0x51, 0x6d, 0x18, 0xb9, 0xa1,
            0x1c, 0xfd, 0x8e, 0x31, 0x03, 0xa1, 0xf6, 0x42, 0xe0, 0x53, 0xc6, 0x03, 0x3d, 0xfa, 0x02, 0xee,
            0xe4, 0xa2, 0x67, 0x68, 0xcb, 0x13, 0x93, 0xa9, 0xa2, 0xef, 0xb9, 0x2e, 0x75, 0xb3, 0x38, 0xf3,
            0x09, 0x0b, 0xf2, 0x75, 0xd2, 0x60, 0x17, 0x67, 0xe2, 0x71, 0xa6, 0x13, 0xd3, 0x9f, 0xc7, 0xc9,
            0x2d, 0x58, 0xc0, 0xe7, 0xcf, 0x38, 0x16, 0xe9, 0xbd, 0xcc, 0x4a, 0x5e, 0xc1, 0x75, 0xbe, 0x12,
            0x22, 0xd5, 0x41, 0xfc, 0xcd, 0xf7, 0xae, 0xe7, 0xf5, 0x73, 0xc3, 0xd9, 0xb4, 0x78, 0x58, 0xff,
            0x7d, 0xcd, 0xdd, 0x2d,
        };
    }
}