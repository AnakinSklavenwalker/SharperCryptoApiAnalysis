﻿using System.ComponentModel.Composition;
using SharperCryptoApiAnalysis.Shell.Interop.Connectivity;

namespace SharperCryptoApiAnalysis.Connectivity.Servers
{
    [GitService("github.com")]
    [Export(typeof(IGitHostServer))]
    internal sealed class GitHubGitHostServer : GitHostServer
    {
        protected override string RawFilesPathBase => Url.Combine(RawFileDomain, LocalRepoPath, BranchSubPath);
        protected override string RawFileDomain => "https://raw.githubusercontent.com";       
    }
}