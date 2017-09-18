﻿using System.ServiceModel;

namespace TGServiceInterface
{
	/// <summary>
	/// Manage the group that is used to access the service, can only be used by an administrator
	/// </summary>
	[ServiceContract]
	public interface ITGAdministration
	{
		/// <summary>
		/// Returns the name of the windows group allowed to use the service other than administrator
		/// </summary>
		/// <returns>The name of the windows group allowed to use the service other than administrator, "ADMIN" if it's unset, null on failure</returns>
		[OperationContract]
		string GetCurrentAuthorizedGroup();

		/// <summary>
		/// Searches the windows machine for the group named <paramref name="groupName"/>, sets it as the authorized group if it's found
		/// </summary>
		/// <param name="groupName">The name of the windows group to search for or null to clear the setting</param>
		/// <returns>The name of the windows group that is now authorized to use the service on success, null on failure, "ADMIN" on clearing</returns>
		[OperationContract]
		string SetAuthorizedGroup(string groupName);
	}
}