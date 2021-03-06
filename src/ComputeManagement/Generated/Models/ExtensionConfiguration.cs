// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Represents an extension that is added to the cloud service.
    /// </summary>
    public partial class ExtensionConfiguration
    {
        private IList<ExtensionConfiguration.Extension> _allRoles;
        
        /// <summary>
        /// Optional. Specifies a list of extensions that are applied to all
        /// roles in a deployment.
        /// </summary>
        public IList<ExtensionConfiguration.Extension> AllRoles
        {
            get { return this._allRoles; }
            set { this._allRoles = value; }
        }
        
        private IList<ExtensionConfiguration.NamedRole> _namedRoles;
        
        /// <summary>
        /// Optional. Specifies a list of extensions that are applied to
        /// specific roles in a deployment.
        /// </summary>
        public IList<ExtensionConfiguration.NamedRole> NamedRoles
        {
            get { return this._namedRoles; }
            set { this._namedRoles = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ExtensionConfiguration class.
        /// </summary>
        public ExtensionConfiguration()
        {
            this.AllRoles = new LazyList<ExtensionConfiguration.Extension>();
            this.NamedRoles = new LazyList<ExtensionConfiguration.NamedRole>();
        }
        
        /// <summary>
        /// Represents an extension that is to be deployed to a role in a cloud
        /// service.
        /// </summary>
        public partial class Extension
        {
            private string _id;
            
            /// <summary>
            /// Required. The identifier of the extension. The identifier is
            /// created when the extension is added to the cloud service. You
            /// can find the ID of an extension that was added to a cloud
            /// service by using List Extensions.
            /// </summary>
            public string Id
            {
                get { return this._id; }
                set { this._id = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Extension class.
            /// </summary>
            public Extension()
            {
            }
            
            /// <summary>
            /// Initializes a new instance of the Extension class with required
            /// arguments.
            /// </summary>
            public Extension(string id)
                : this()
            {
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }
                this.Id = id;
            }
        }
        
        /// <summary>
        /// Specifies a list of extensions that are applied to specific roles
        /// in a deployment.
        /// </summary>
        public partial class NamedRole
        {
            private IList<ExtensionConfiguration.Extension> _extensions;
            
            /// <summary>
            /// Required. Represents an extension that is to be deployed to a
            /// role in a cloud service.
            /// </summary>
            public IList<ExtensionConfiguration.Extension> Extensions
            {
                get { return this._extensions; }
                set { this._extensions = value; }
            }
            
            private string _roleName;
            
            /// <summary>
            /// Required. Specifies the name of the role.
            /// </summary>
            public string RoleName
            {
                get { return this._roleName; }
                set { this._roleName = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the NamedRole class.
            /// </summary>
            public NamedRole()
            {
                this.Extensions = new LazyList<ExtensionConfiguration.Extension>();
            }
            
            /// <summary>
            /// Initializes a new instance of the NamedRole class with required
            /// arguments.
            /// </summary>
            public NamedRole(string roleName, IList<ExtensionConfiguration.Extension> extensions)
                : this()
            {
                if (roleName == null)
                {
                    throw new ArgumentNullException("roleName");
                }
                if (extensions == null)
                {
                    throw new ArgumentNullException("extensions");
                }
                this.RoleName = roleName;
                this.Extensions = extensions;
            }
        }
    }
}
