﻿using ApplicationInsights.Kubernetes.HostingStartup;
using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(K8sInjection))]