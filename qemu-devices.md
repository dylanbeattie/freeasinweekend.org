```
E:\corel-linux    qemu-system-i386 -audiodev help
Available audio drivers:
none
dsound
jack
sdl
spice
wav
 E:\corel-linux   
```





## Controller/Bridge/Hub devices:

name "cxl-downstream", bus PCI, desc "CXL Switch Downstream Port"
name "cxl-rp", bus PCI, desc "CXL Root Port"
name "cxl-upstream", bus PCI, desc "CXL Switch Upstream Port"
name "i82801b11-bridge", bus PCI
name "ioh3420", bus PCI, desc "Intel IOH device id 3420 PCIE Root Port"
name "pci-bridge", bus PCI, desc "Standard PCI Bridge"
name "pci-bridge-seat", bus PCI, desc "Standard PCI Bridge (multiseat)"
name "pcie-pci-bridge", bus PCI
name "pcie-root-port", bus PCI, desc "PCI Express Root Port"
name "pxb", bus PCI, desc "PCI Expander Bridge"
name "pxb-cxl", bus PCI, desc "CXL Host Bridge"
name "pxb-pcie", bus PCI, desc "PCI Express Expander Bridge"
name "usb-host", bus usb-bus
name "usb-hub", bus usb-bus
name "x3130-upstream", bus PCI, desc "TI X3130 Upstream Port of PCI Express Switch"
name "xio3130-downstream", bus PCI, desc "TI X3130 Downstream Port of PCI Express Switch"

### USB devices:

name "ich9-usb-ehci1", bus PCI
name "ich9-usb-ehci2", bus PCI
name "ich9-usb-uhci1", bus PCI
name "ich9-usb-uhci2", bus PCI
name "ich9-usb-uhci3", bus PCI
name "ich9-usb-uhci4", bus PCI
name "ich9-usb-uhci5", bus PCI
name "ich9-usb-uhci6", bus PCI
name "nec-usb-xhci", bus PCI
name "pci-ohci", bus PCI, desc "Apple USB Controller"
name "piix3-usb-uhci", bus PCI
name "piix4-usb-uhci", bus PCI
name "qemu-xhci", bus PCI
name "usb-ehci", bus PCI

### Storage devices:

name "am53c974", bus PCI, desc "AMD Am53c974 PCscsi-PCI SCSI adapter"
name "cxl-type3", bus PCI, desc "CXL Memory Device (Type 3)"
name "dc390", bus PCI, desc "Tekram DC-390 SCSI adapter"
name "floppy", bus floppy-bus, desc "virtual floppy drive"
name "ich9-ahci", bus PCI, alias "ahci"
name "ide-cd", bus IDE, desc "virtual IDE CD-ROM"
name "ide-cf", bus IDE, desc "virtual CompactFlash card"
name "ide-hd", bus IDE, desc "virtual IDE disk"
name "isa-fdc", bus ISA, desc "virtual floppy controller"
name "isa-ide", bus ISA
name "lsi53c810", bus PCI
name "lsi53c895a", bus PCI, alias "lsi"
name "megasas", bus PCI, desc "LSI MegaRAID SAS 1078"
name "megasas-gen2", bus PCI, desc "LSI MegaRAID SAS 2108"
name "mptsas1068", bus PCI, desc "LSI SAS 1068"
name "nvdimm", desc "DIMM memory module"
name "nvme", bus PCI, desc "Non-Volatile Memory Express"
name "nvme-ns", bus nvme-bus, desc "Virtual NVMe namespace"
name "nvme-subsys", desc "Virtual NVMe subsystem"
name "piix3-ide", bus PCI
name "piix4-ide", bus PCI
name "pvscsi", bus PCI
name "scsi-cd", bus SCSI, desc "virtual SCSI CD-ROM"
name "scsi-hd", bus SCSI, desc "virtual SCSI disk"
name "sd-card", bus sd-bus
name "sd-card-spi", bus sd-bus, desc "SD SPI"
name "sdhci-pci", bus PCI
name "ufs", bus PCI, desc "Universal Flash Storage"
name "usb-bot", bus usb-bus
name "usb-storage", bus usb-bus
name "usb-uas", bus usb-bus
name "virtio-blk-device", bus virtio-bus
name "virtio-blk-pci", bus PCI, alias "virtio-blk"
name "virtio-blk-pci-non-transitional", bus PCI
name "virtio-blk-pci-transitional", bus PCI
name "virtio-pmem", bus virtio-bus
name "virtio-scsi-device", bus virtio-bus
name "virtio-scsi-pci", bus PCI, alias "virtio-scsi"
name "virtio-scsi-pci-non-transitional", bus PCI
name "virtio-scsi-pci-transitional", bus PCI

### Network devices:

name "e1000", bus PCI, alias "e1000-82540em", desc "Intel Gigabit Ethernet"
name "e1000-82544gc", bus PCI, desc "Intel Gigabit Ethernet"
name "e1000-82545em", bus PCI, desc "Intel Gigabit Ethernet"
name "e1000e", bus PCI, desc "Intel 82574L GbE Controller"
name "i82550", bus PCI, desc "Intel i82550 Ethernet"
name "i82551", bus PCI, desc "Intel i82551 Ethernet"
name "i82557a", bus PCI, desc "Intel i82557A Ethernet"
name "i82557b", bus PCI, desc "Intel i82557B Ethernet"
name "i82557c", bus PCI, desc "Intel i82557C Ethernet"
name "i82558a", bus PCI, desc "Intel i82558A Ethernet"
name "i82558b", bus PCI, desc "Intel i82558B Ethernet"
name "i82559a", bus PCI, desc "Intel i82559A Ethernet"
name "i82559b", bus PCI, desc "Intel i82559B Ethernet"
name "i82559c", bus PCI, desc "Intel i82559C Ethernet"
name "i82559er", bus PCI, desc "Intel i82559ER Ethernet"
name "i82562", bus PCI, desc "Intel i82562 Ethernet"
name "i82801", bus PCI, desc "Intel i82801 Ethernet"
name "igb", bus PCI, desc "Intel 82576 Gigabit Ethernet Controller"
name "ne2k_isa", bus ISA
name "ne2k_pci", bus PCI
name "pcnet", bus PCI
name "rocker", bus PCI, desc "Rocker Switch"
name "rtl8139", bus PCI
name "tulip", bus PCI
name "usb-net", bus usb-bus
name "virtio-net-device", bus virtio-bus
name "virtio-net-pci", bus PCI, alias "virtio-net"
name "virtio-net-pci-non-transitional", bus PCI
name "virtio-net-pci-transitional", bus PCI
name "vmxnet3", bus PCI, desc "VMWare Paravirtualized Ethernet v3"

### Input devices:

name "ccid-card-emulated", bus ccid-bus, desc "emulated smartcard"
name "ccid-card-passthru", bus ccid-bus, desc "passthrough smartcard"
name "i8042", bus ISA
name "ipoctal232", bus IndustryPack, desc "GE IP-Octal 232 8-channel RS-232 IndustryPack"
name "isa-parallel", bus ISA
name "isa-serial", bus ISA
name "pci-serial", bus PCI
name "pci-serial-2x", bus PCI
name "pci-serial-4x", bus PCI
name "tpci200", bus PCI, desc "TEWS TPCI200 IndustryPack carrier"
name "usb-braille", bus usb-bus
name "usb-ccid", bus usb-bus, desc "CCID Rev 1.1 smartcard reader"
name "usb-kbd", bus usb-bus
name "usb-mouse", bus usb-bus
name "usb-serial", bus usb-bus
name "usb-tablet", bus usb-bus
name "usb-wacom-tablet", bus usb-bus, desc "QEMU PenPartner Tablet"
name "virtconsole", bus virtio-serial-bus
name "virtio-keyboard-device", bus virtio-bus
name "virtio-keyboard-pci", bus PCI, alias "virtio-keyboard"
name "virtio-mouse-device", bus virtio-bus
name "virtio-mouse-pci", bus PCI, alias "virtio-mouse"
name "virtio-multitouch-device", bus virtio-bus
name "virtio-multitouch-pci", bus PCI
name "virtio-serial-device", bus virtio-bus
name "virtio-serial-pci", bus PCI, alias "virtio-serial"
name "virtio-serial-pci-non-transitional", bus PCI
name "virtio-serial-pci-transitional", bus PCI
name "virtio-tablet-device", bus virtio-bus
name "virtio-tablet-pci", bus PCI, alias "virtio-tablet"
name "virtserialport", bus virtio-serial-bus
name "vmmouse", bus ISA

### Display devices:

name "ati-vga", bus PCI
name "bochs-display", bus PCI
name "cirrus-vga", bus PCI, desc "Cirrus CLGD 54xx VGA"
name "isa-cirrus-vga", bus ISA
name "isa-vga", bus ISA
name "qxl", bus PCI, desc "Spice QXL GPU (secondary)"
name "qxl-vga", bus PCI, desc "Spice QXL GPU (primary, vga compatible)"
name "ramfb", bus System, desc "ram framebuffer standalone device"
name "secondary-vga", bus PCI
name "VGA", bus PCI
name "virtio-gpu-device", bus virtio-bus
name "virtio-gpu-gl-device", bus virtio-bus
name "virtio-gpu-gl-pci", bus PCI, alias "virtio-gpu-gl"
name "virtio-gpu-pci", bus PCI, alias "virtio-gpu"
name "virtio-vga", bus PCI
name "virtio-vga-gl", bus PCI
name "vmware-svga", bus PCI

### Sound devices:

name "AC97", bus PCI, alias "ac97", desc "Intel 82801AA AC97 Audio"
name "adlib", bus ISA, desc "Yamaha YM3812 (OPL2)"
name "cs4231a", bus ISA, desc "Crystal Semiconductor CS4231A"
name "ES1370", bus PCI, alias "es1370", desc "ENSONIQ AudioPCI ES1370"
name "gus", bus ISA, desc "Gravis Ultrasound GF1"
name "hda-duplex", bus HDA, desc "HDA Audio Codec, duplex (line-out, line-in)"
name "hda-micro", bus HDA, desc "HDA Audio Codec, duplex (speaker, microphone)"
name "hda-output", bus HDA, desc "HDA Audio Codec, output-only (line-out)"
name "ich9-intel-hda", bus PCI, desc "Intel HD Audio Controller (ich9)"
name "intel-hda", bus PCI, desc "Intel HD Audio Controller (ich6)"
name "sb16", bus ISA, desc "Creative Sound Blaster 16"
name "usb-audio", bus usb-bus
name "virtio-sound-device", bus virtio-bus
name "virtio-sound-pci", bus PCI, alias "virtio-sound", desc "Virtio Sound"

### Misc devices:

name "acpi-erst", bus PCI, desc "ACPI Error Record Serialization Table (ERST) device"
name "amd-iommu", bus System, desc "AMD IOMMU (AMD-Vi) DMA Remapping device"
name "AMDVI-PCI", bus PCI, desc "AMD IOMMU (AMD-Vi) DMA Remapping device"
name "ctucan_pci", bus PCI, desc "CTU CAN PCI"
name "edu", bus PCI
name "guest-loader", desc "Guest Loader"
name "i2c-ddc", bus i2c-bus
name "i2c-echo", bus i2c-bus
name "intel-iommu", bus System, desc "Intel IOMMU (VT-d) DMA Remapping device"
name "isa-applesmc", bus ISA
name "isa-debug-exit", bus ISA
name "isa-debugcon", bus ISA
name "kvaser_pci", bus PCI, desc "Kvaser PCICANx"
name "loader", desc "Generic Loader"
name "mc146818rtc", bus ISA
name "mioe3680_pci", bus PCI, desc "Mioe3680 PCICANx"
name "pc-testdev", bus ISA
name "pci-testdev", bus PCI, desc "PCI Test Device"
name "pcm3680_pci", bus PCI, desc "Pcm3680i PCICANx"
name "pvpanic", bus ISA
name "pvpanic-pci", bus PCI
name "smbus-ipmi", bus i2c-bus
name "usb-redir", bus usb-bus
name "virtio-balloon-device", bus virtio-bus
name "virtio-balloon-pci", bus PCI, alias "virtio-balloon"
name "virtio-balloon-pci-non-transitional", bus PCI
name "virtio-balloon-pci-transitional", bus PCI
name "virtio-crypto-device", bus virtio-bus
name "virtio-crypto-pci", bus PCI
name "virtio-iommu-device", bus virtio-bus
name "virtio-iommu-pci", bus PCI, alias "virtio-iommu"
name "virtio-pmem-pci", bus PCI
name "virtio-rng-device", bus virtio-bus
name "virtio-rng-pci", bus PCI, alias "virtio-rng"
name "virtio-rng-pci-non-transitional", bus PCI
name "virtio-rng-pci-transitional", bus PCI
name "vmcoreinfo"
name "vmgenid"

### CPU devices:

name "486-i386-cpu"
name "486-v1-i386-cpu"
name "athlon-i386-cpu"
name "athlon-v1-i386-cpu"
name "base-i386-cpu"
name "Broadwell-i386-cpu"
name "Broadwell-IBRS-i386-cpu"
name "Broadwell-noTSX-i386-cpu"
name "Broadwell-noTSX-IBRS-i386-cpu"
name "Broadwell-v1-i386-cpu"
name "Broadwell-v2-i386-cpu"
name "Broadwell-v3-i386-cpu"
name "Broadwell-v4-i386-cpu"
name "Cascadelake-Server-i386-cpu"
name "Cascadelake-Server-noTSX-i386-cpu"
name "Cascadelake-Server-v1-i386-cpu"
name "Cascadelake-Server-v2-i386-cpu"
name "Cascadelake-Server-v3-i386-cpu"
name "Cascadelake-Server-v4-i386-cpu"
name "Cascadelake-Server-v5-i386-cpu"
name "Conroe-i386-cpu"
name "Conroe-v1-i386-cpu"
name "Cooperlake-i386-cpu"
name "Cooperlake-v1-i386-cpu"
name "Cooperlake-v2-i386-cpu"
name "core2duo-i386-cpu"
name "core2duo-v1-i386-cpu"
name "coreduo-i386-cpu"
name "coreduo-v1-i386-cpu"
name "Denverton-i386-cpu"
name "Denverton-v1-i386-cpu"
name "Denverton-v2-i386-cpu"
name "Denverton-v3-i386-cpu"
name "Dhyana-i386-cpu"
name "Dhyana-v1-i386-cpu"
name "Dhyana-v2-i386-cpu"
name "EPYC-Genoa-i386-cpu"
name "EPYC-Genoa-v1-i386-cpu"
name "EPYC-i386-cpu"
name "EPYC-IBPB-i386-cpu"
name "EPYC-Milan-i386-cpu"
name "EPYC-Milan-v1-i386-cpu"
name "EPYC-Milan-v2-i386-cpu"
name "EPYC-Rome-i386-cpu"
name "EPYC-Rome-v1-i386-cpu"
name "EPYC-Rome-v2-i386-cpu"
name "EPYC-Rome-v3-i386-cpu"
name "EPYC-Rome-v4-i386-cpu"
name "EPYC-v1-i386-cpu"
name "EPYC-v2-i386-cpu"
name "EPYC-v3-i386-cpu"
name "EPYC-v4-i386-cpu"
name "GraniteRapids-i386-cpu"
name "GraniteRapids-v1-i386-cpu"
name "Haswell-i386-cpu"
name "Haswell-IBRS-i386-cpu"
name "Haswell-noTSX-i386-cpu"
name "Haswell-noTSX-IBRS-i386-cpu"
name "Haswell-v1-i386-cpu"
name "Haswell-v2-i386-cpu"
name "Haswell-v3-i386-cpu"
name "Haswell-v4-i386-cpu"
name "Icelake-Server-i386-cpu"
name "Icelake-Server-noTSX-i386-cpu"
name "Icelake-Server-v1-i386-cpu"
name "Icelake-Server-v2-i386-cpu"
name "Icelake-Server-v3-i386-cpu"
name "Icelake-Server-v4-i386-cpu"
name "Icelake-Server-v5-i386-cpu"
name "Icelake-Server-v6-i386-cpu"
name "IvyBridge-i386-cpu"
name "IvyBridge-IBRS-i386-cpu"
name "IvyBridge-v1-i386-cpu"
name "IvyBridge-v2-i386-cpu"
name "KnightsMill-i386-cpu"
name "KnightsMill-v1-i386-cpu"
name "kvm32-i386-cpu"
name "kvm32-v1-i386-cpu"
name "kvm64-i386-cpu"
name "kvm64-v1-i386-cpu"
name "max-i386-cpu"
name "n270-i386-cpu"
name "n270-v1-i386-cpu"
name "Nehalem-i386-cpu"
name "Nehalem-IBRS-i386-cpu"
name "Nehalem-v1-i386-cpu"
name "Nehalem-v2-i386-cpu"
name "Opteron_G1-i386-cpu"
name "Opteron_G1-v1-i386-cpu"
name "Opteron_G2-i386-cpu"
name "Opteron_G2-v1-i386-cpu"
name "Opteron_G3-i386-cpu"
name "Opteron_G3-v1-i386-cpu"
name "Opteron_G4-i386-cpu"
name "Opteron_G4-v1-i386-cpu"
name "Opteron_G5-i386-cpu"
name "Opteron_G5-v1-i386-cpu"
name "Penryn-i386-cpu"
name "Penryn-v1-i386-cpu"
name "pentium-i386-cpu"
name "pentium-v1-i386-cpu"
name "pentium2-i386-cpu"
name "pentium2-v1-i386-cpu"
name "pentium3-i386-cpu"
name "pentium3-v1-i386-cpu"
name "phenom-i386-cpu"
name "phenom-v1-i386-cpu"
name "qemu32-i386-cpu"
name "qemu32-v1-i386-cpu"
name "qemu64-i386-cpu"
name "qemu64-v1-i386-cpu"
name "SandyBridge-i386-cpu"
name "SandyBridge-IBRS-i386-cpu"
name "SandyBridge-v1-i386-cpu"
name "SandyBridge-v2-i386-cpu"
name "SapphireRapids-i386-cpu"
name "SapphireRapids-v1-i386-cpu"
name "SapphireRapids-v2-i386-cpu"
name "Skylake-Client-i386-cpu"
name "Skylake-Client-IBRS-i386-cpu"
name "Skylake-Client-noTSX-IBRS-i386-cpu"
name "Skylake-Client-v1-i386-cpu"
name "Skylake-Client-v2-i386-cpu"
name "Skylake-Client-v3-i386-cpu"
name "Skylake-Client-v4-i386-cpu"
name "Skylake-Server-i386-cpu"
name "Skylake-Server-IBRS-i386-cpu"
name "Skylake-Server-noTSX-IBRS-i386-cpu"
name "Skylake-Server-v1-i386-cpu"
name "Skylake-Server-v2-i386-cpu"
name "Skylake-Server-v3-i386-cpu"
name "Skylake-Server-v4-i386-cpu"
name "Skylake-Server-v5-i386-cpu"
name "Snowridge-i386-cpu"
name "Snowridge-v1-i386-cpu"
name "Snowridge-v2-i386-cpu"
name "Snowridge-v3-i386-cpu"
name "Snowridge-v4-i386-cpu"
name "Westmere-i386-cpu"
name "Westmere-IBRS-i386-cpu"
name "Westmere-v1-i386-cpu"
name "Westmere-v2-i386-cpu"

### Watchdog devices:

name "i6300esb", bus PCI, desc "Intel 6300ESB"
name "ib700", bus ISA, desc "iBASE 700"

### Uncategorized devices:

name "cxl-switch-mailbox-cci", bus PCI, desc "CXL Switch Mailbox CCI"
name "ipmi-bmc-extern"
name "ipmi-bmc-sim"
name "isa-ipmi-bt", bus ISA
name "isa-ipmi-kcs", bus ISA
name "pc-dimm", desc "DIMM memory module"
name "pci-ipmi-bt", bus PCI, desc "PCI IPMI BT"
name "pci-ipmi-kcs", bus PCI, desc "PCI IPMI KCS"
name "ufs-lu", bus ufs-bus, desc "Virtual UFS logical unit"